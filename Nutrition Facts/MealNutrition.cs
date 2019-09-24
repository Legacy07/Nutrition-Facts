namespace Nutrition_Facts
{
    public class MealNutrition
    {
        public string Name { get; set; }
        public string ServingSize { get; set; }
        public string Calorie { get; set; }
        public string Protein { get; set; }
        public string Carbohydrate { get; set; }
        public string Fat { get; set; }

        public MealNutrition(string name, string servingSize, string calorie, string protein, string carbohydrate, string fat)
        {
            Name = name;
            ServingSize = servingSize;
            Calorie = calorie;
            Protein = protein;
            Carbohydrate = carbohydrate;
            Fat = fat;
        }

        public MealNutrition()
        {
            this.Name = string.Empty;
            this.ServingSize = string.Empty;
            this.Calorie = string.Empty;
            this.Protein = string.Empty;
            this.Carbohydrate = string.Empty;
            this.Fat = string.Empty;
        }
    }
}
