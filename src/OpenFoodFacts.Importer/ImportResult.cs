using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFoodFacts.Importer
{
    public class ImportResult
    {
        public ImportResult()
        {
            Successful = true;
        }

        public bool Successful { get; set; }
        public int TotalRecords { get; set; }
        public int ImportCount { get; set; }
        public int FailedCount { get; set; }
    }
}
