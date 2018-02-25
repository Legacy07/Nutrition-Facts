using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition_Facts
{
    class Calorie_Breakdown
    {
        //1 gram of fat is 9 calories
        public static decimal fatToCalories(decimal fat)
        {
            decimal totalCalories = fat * 9;

            return totalCalories;
        }
        //1 gram of carb in 4 calories
        public static decimal carbToCalories(decimal carb)
        {
            decimal totalCalories = carb * 4;

            return totalCalories;
        }
        //1 gram of protein is 4 calories
        public static decimal proteinToCalories(decimal protein)
        {
            decimal totalCalories = protein * 4;

            return totalCalories;
        }
        //percentage of fat in total Calories
        public static decimal caloriesInFat(decimal fatCalories, decimal calories)
        {
            decimal totalCalories = (fatCalories / calories) * 100;

            return totalCalories;
        }
        //percentage of carb in total Calories
        public static decimal caloriesInCarb(decimal carbCalories, decimal calories)
        {
            decimal totalCalories = (carbCalories / calories) * 100;

            return totalCalories;
        }
        //percentage of protein in total Calories
        public static decimal caloriesinProtein(decimal proteinCalories, decimal calories)
        {
            decimal totalCalories = (proteinCalories / calories) * 100;

            return totalCalories;

        }
    }
}
