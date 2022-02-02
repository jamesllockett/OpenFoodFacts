using System;

namespace OpenFoodFacts.Model
{
    public class FoodRecord
    {
        public string Code { get; set; }
        public string ProductName { get; set; }
        public string ProductNameAbbreviated { get; set; }
        public int CreatedUnix { get; set; }
        public DateTime? Created { get; set; }
        public int LastModifiedUnix { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
