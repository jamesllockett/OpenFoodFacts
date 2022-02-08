using System;

namespace OpenFoodFacts.Model
{
    public class FoodRecord
    {
        public FoodRecord()
        {
            Nutrition = new Nutrition();
            Ingredients = new Ingredients();
        }

        public string Code { get; set; }
        public string ProductName { get; set; }
        public string ProductNameAbbreviated { get; set; }
        public string BrandOwner { get; set; }
        public string Category { get; set; }

        public int CreatedUnix { get; set; }
        public DateTime? Created { get; set; }
        public int LastModifiedUnix { get; set; }
        public DateTime? LastModified { get; set; }

        public Nutrition Nutrition { get; set; }
        public Ingredients Ingredients { get; set; }
    }
}
