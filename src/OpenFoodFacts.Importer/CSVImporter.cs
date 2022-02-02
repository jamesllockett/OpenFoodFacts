using OpenFoodFacts.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenFoodFacts.Importer
{
    public class CSVImporter : Importer
    {
        const char Delimiter = '\t';
        const char Terminator = '\n';

        private readonly ICSVVersion version;

        private char[] unprocessed;
        bool headerProcessed;

        public CSVImporter(IFoodReader reader, IFoodWriter writer, ICSVVersion version)
            : base(reader, writer)
        {
            this.version = version;
            this.headerProcessed = !version.IncludesHeaderRow;
            this.unprocessed = Array.Empty<char>();
        }

        protected override void OnImportStarting()
        {
            // Reset local values
            this.headerProcessed = !version.IncludesHeaderRow;
            this.unprocessed = Array.Empty<char>();
        }

        protected override void OnImportFinished()
        {
            if (unprocessed != null && unprocessed.Length > 0)
            {
                //TODO: Throw proper exception
                throw new Exception();
            }

            base.OnImportFinished();
        }

        protected override FoodRecord[] ProcessData(char[] data)
        {
            List<FoodRecord> records = new List<FoodRecord>();
            int position = 0;

            // Combine previous left-over with next chunk data
            var combined = Combine(unprocessed, data);

            do
            {
                position = ProcessData(combined, position, out FoodRecord food);

                if (food != null)
                {
                    records.Add(food);
                }

            } while (position < data.Length - 1);

            return records.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="start"></param>
        /// <param name="foodRecord"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        protected int ProcessData(char[] data, int start, out FoodRecord foodRecord)
        {
            int c, s;
            Queue<string> values = new Queue<string>();

            // Iterate complete data set, processing each item
            for (c = start, s = start; c < data.Length; c++)
            {
                if (data[c] == Delimiter || data[c] == Terminator)
                {
                    // Add item to queue
                    values.Enqueue(ExtractString(data, s, c));

                    // Move start onto start of next character
                    s = c + 1;
                }

                // Have we reached the end of the record?
                if (data[c] == Terminator)
                {
                    // Do we have more data?  If so, copy it to the unprocessed buffer
                    if (c < data.Length - 1)
                    {
                        unprocessed = new char[data.Length - c];
                        data.CopyTo(unprocessed, c + 1);
                    }

                    // Finish processing the data
                    break;
                }
                else if (values.Count > version.HeadingCount)
                {
                    //TODO: Throw proper exception
                    throw new Exception();
                }
            }

            // If we have reached the end of the buffer and not got enough data, move it to the uprocessed buffer and move on to the next chunk
            if (c == data.Length && values.Count < version.HeadingCount)
            {
                unprocessed = new char[c - start];
                data.CopyTo(unprocessed, start);
                foodRecord = null;
            }
            else
            {
                // Validate the header
                if (!headerProcessed)
                {
                    // Validate the header
                    if (!CompareCollections(version.Headings, values))
                    {
                        //TODO: throw appropriate exception
                        throw new Exception();
                    }

                    foodRecord = null;
                    headerProcessed = true;
                }
                else
                {
                    // Construct Food record
                    foodRecord = BuildRecord(values);
                }
            }

            return c;
        }

        /// <summary>
        /// Combine two char arrays
        /// </summary>
        /// <param name="previous"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        private char[] Combine(char[] previous, char[] current)
        {
            char[] combined = new char[previous.Length + current.Length];

            // If previous has data, copy it into new array
            if (previous.Length > 0)
            {
                previous.CopyTo(combined, 0);
            }

            // copy current data into array
            current.CopyTo(combined, previous.Length);

            return combined;
        }

        /// <summary>
        /// Get a string from within a chracter array
        /// </summary>
        /// <param name="data"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private string ExtractString(char[] data, int start, int end)
        {
            return new string(data, start, end - start);
        }

        /// <summary>
        /// Build the food record from extracted values
        /// </summary>
        /// <param name="parts">Parts extracted from read in chunk</param>
        /// <returns>The constructed food record</returns>
        private FoodRecord BuildRecord(Queue<string> parts)
        {
            int fieldIndex = 0;
            string fieldValue = String.Empty;

            FoodRecord foodRecord = new FoodRecord();

            while (parts.TryDequeue(out fieldValue))
            {
                switch (version.Headings[fieldIndex])
                {
                    case FoodConstants.Code:
                        foodRecord.Code = fieldValue; break;
                    case FoodConstants.CreatedT:
                        foodRecord.CreatedUnix = Int32.Parse(fieldValue); break;

                    default:
                        continue;   // Ignore fields not interested in
                }
            }

            return foodRecord;
        }

        /// <summary>
        /// Compare the header array with the values queue
        /// </summary>
        /// <param name="header">Array of headers</param>
        /// <param name="values">Values queue</param>
        /// <returns></returns>
        private bool CompareCollections(string[] header, Queue<string> values)
        {
            if (header.Length != values.Count)
                return false;

            int counter = 0;

            foreach (String value in values)
            {
                if (String.Compare(header[counter], value, true) != 0)
                {
                    return false;
                }

                counter++;
            }

            return true;
        }
    }
}
