using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrition_Facts
{
    public partial class AddToMealsForm : Form
    {
        public MealNutrition meals { get; set; }
        public DashboardForm mealsForm { get; set; }

        public AddToMealsForm()
        {
            InitializeComponent();

            this.meals = new MealNutrition();
        }

        private void addMealButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.mealsForm.setMeals(this.meals, this.mealTypeComboBox.SelectedItem.ToString());
            this.mealsForm.Show();
        }
    }
}
