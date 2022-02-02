using OpenFoodFacts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFoodFacts.Importer
{
    public interface IFoodWriter
    {
        /// <summary>
        /// Write the records to storage
        /// </summary>
        /// <param name="record"></param>
        /// <returns>Total records written</returns>
        Task<int> WriteAsync(params FoodRecord[] record);
    }
}
