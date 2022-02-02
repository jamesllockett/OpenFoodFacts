using OpenFoodFacts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFoodFacts.Importer
{
    public abstract class Importer
    {
        public IFoodReader Reader { get; }
        public IFoodWriter Writer { get; }

        /// <summary>
        /// Construct the food importer, providing the source (reader) and target (writier)
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="writer"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Importer(IFoodReader reader, IFoodWriter writer)
        {
            Reader = reader ?? throw new ArgumentNullException(nameof(reader));
            Writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        /// <summary>
        /// Method to import the data
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public async Task<ImportResult> ImportAsync()
        {
            ImportResult result = new ImportResult();

            // Allow initialisation
            OnImportStarting();

            // Keep reading until no data is left
            await foreach(char[] databuffer in Reader.ReadChunksAsync())
            {
                // Process the chunk of data
                var records = this.ProcessData(databuffer);

                // Write records
                int written = await Writer.WriteAsync(records);

                // Update results
                result.ImportCount += written;
                result.TotalRecords += records.Length;
                result.Successful &= (records.Length == written);
            }

            // Allow for cleanup
            OnImportFinished();

            return result;
        }

        protected virtual void OnImportStarting() { }

        protected virtual void OnImportFinished() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        protected abstract FoodRecord[] ProcessData(char[] data);
    }
}
