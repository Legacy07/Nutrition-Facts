using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrition_Facts
{
    public partial class MealsForm : Form
    {
        public MealNutrition meals { get; set; }

        public List<MealNutrition> mealsList { get; set; } = new List<MealNutrition>();

        public MealsForm()
        {
            InitializeComponent();
        }

        private void MealsForm_Load(object sender, EventArgs e)
        {

        }

        public void setMeals(MealNutrition meals)
        {
            this.mealsList.Add(meals);
        }
    }
}
