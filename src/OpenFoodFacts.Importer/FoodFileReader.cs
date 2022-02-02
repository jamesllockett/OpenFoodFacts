using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace OpenFoodFacts.Importer
{
    internal class FoodFileReader : IFoodReader
    {
        public string FilePath { get; }

        public FoodFileReader(string filepath)
        {
            FilePath = filepath;
        }

        public async IAsyncEnumerable<char[]> ReadChunksAsync()
        {
            using (var fs = System.IO.File.OpenRead(FilePath))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    string line = await reader.ReadLineAsync();

                    line += '\n';

                    yield return line.ToCharArray();
                }
            }
        }
    }
}
