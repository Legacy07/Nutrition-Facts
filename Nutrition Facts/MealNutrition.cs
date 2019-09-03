using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition_Facts
{
    public class MealNutrition
    {
        public string Name { get; set; }
        public string Calorie { get; set; }
        public string Protein { get; set; }
        public string Carbohydrate { get; set; }
        public string Fat { get; set; }

        public MealNutrition(string name, string calorie, string protein, string carbohydrate, string fat)
        {
            Name = name;
            Calorie = calorie;
            Protein = protein;
            Carbohydrate = carbohydrate;
            Fat = fat;
        }
    }
}
