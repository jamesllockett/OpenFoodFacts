using OpenFoodFacts.Importer;
using OpenFoodFacts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFoodFacts.Test.Importer
{
    internal class StubWriter : IFoodWriter
    {
        public async Task<int> WriteAsync(params FoodRecord[] record)
        {
            return record.Length;
        }
    }
}
