using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFoodFacts.Importer
{
    public interface IFoodReader
    {
        IAsyncEnumerable<char[]> ReadChunksAsync();
    }
}
