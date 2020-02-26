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
    public partial class DashboardForm : Form
    {
        public MealNutrition meals { get; set; }

        public Dictionary<string, MealNutrition> mealsList { get; set; } = new Dictionary<string, MealNutrition>();

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void MealsForm_Load(object sender, EventArgs e)
        {

        }

        public void setMeals(MealNutrition meals, string mealType)
        {
            this.mealsList.Add(mealType, meals);

        ////https://www.google.com/search?q=flowlayout-anel+winforsm&oq=flowlayout-anel+winforsm&aqs=chrome..69i57j0l5.5027j0j7&sourceid=chrome&ie=UTF-8
            this.AddPanel();
        }

        private void AddPanel()
        {
            var panel = new Panel();
            var mealNameLabel = new Label();
            var mealNameTextBox = new TextBox();

            var caloriesLabel = new Label();
            var caloriesTextBox = new TextBox();

            var proteinLabel = new Label();
            var proteinTextBox = new TextBox();

            var carbsLabel = new Label();
            var carbsTextBox = new TextBox();

            var fatLabel = new Label();
            var fatTextBox = new TextBox();

            var servingSizeLabel = new Label();
            var servingSizeTextBox = new TextBox();

            panel.BackColor = System.Drawing.Color.DimGray;
            panel.Controls.Add(servingSizeTextBox);
            panel.Controls.Add(servingSizeLabel);
            panel.Controls.Add(mealNameTextBox);
            panel.Controls.Add(mealNameLabel);
            panel.Controls.Add(fatTextBox);
            panel.Controls.Add(fatLabel);
            panel.Controls.Add(carbsTextBox);
            panel.Controls.Add(carbsLabel);
            panel.Controls.Add(proteinTextBox);
            panel.Controls.Add(proteinLabel);
            panel.Controls.Add(caloriesTextBox);
            panel.Controls.Add(caloriesLabel);
            panel.Location = new System.Drawing.Point(10, 15);
            panel.Name = "mealPanel";
            panel.Size = new System.Drawing.Size(232, 400);
            panel.TabIndex = 0;

            // label9
            // 
            mealNameLabel.AutoSize = true;
            mealNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            mealNameLabel.Location = new System.Drawing.Point(3, 12);
            mealNameLabel.Name = "mealNameLabel";
            mealNameLabel.Size = new System.Drawing.Size(38, 17);
            mealNameLabel.TabIndex = 0;
            mealNameLabel.Text = "Meal";
            // 
            // mealNameTextBox
            // 
            mealNameTextBox.Enabled = false;
            mealNameTextBox.Location = new System.Drawing.Point(6, 32);
            mealNameTextBox.Name = "mealNameTextBox";
            mealNameTextBox.Size = new System.Drawing.Size(223, 22);
            mealNameTextBox.TabIndex = 1;
            // 
            // caloriesTextBox
            // 
            caloriesTextBox.Enabled = false;
            caloriesTextBox.Location = new System.Drawing.Point(6, 123);
            caloriesTextBox.Name = "caloriesTextBox";
            caloriesTextBox.Size = new System.Drawing.Size(223, 22);
            caloriesTextBox.TabIndex = 3;
            // 
            // caloriesLabel
            // 
            caloriesLabel.AutoSize = true;
            caloriesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            caloriesLabel.Location = new System.Drawing.Point(3, 102);
            caloriesLabel.Name = "caloriesLabel";
            caloriesLabel.Size = new System.Drawing.Size(59, 17);
            caloriesLabel.TabIndex = 2;
            caloriesLabel.Text = "Calories";
            // 
            // proteinTextBox
            // 
            proteinTextBox.Enabled = false;
            proteinTextBox.Location = new System.Drawing.Point(6, 169);
            proteinTextBox.Name = "proteinTextBox";
            proteinTextBox.Size = new System.Drawing.Size(223, 22);
            proteinTextBox.TabIndex = 5;
            // 
            // proteinLabel
            // 
            proteinLabel.AutoSize = true;
            proteinLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            proteinLabel.Location = new System.Drawing.Point(3, 149);
            proteinLabel.Name = "proteinLabel";
            proteinLabel.Size = new System.Drawing.Size(53, 17);
            proteinLabel.TabIndex = 4;
            proteinLabel.Text = "Protein";
            // 
            // carbsTextBox
            // 
            carbsTextBox.Enabled = false;
            carbsTextBox.Location = new System.Drawing.Point(6, 215);
            carbsTextBox.Name = "carbsTextBox";
            carbsTextBox.Size = new System.Drawing.Size(223, 22);
            carbsTextBox.TabIndex = 7;
            // 
            // label12
            // 
            carbsLabel.AutoSize = true;
            carbsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            carbsLabel.Location = new System.Drawing.Point(3, 195);
            carbsLabel.Name = "carbsLabel";
            carbsLabel.Size = new System.Drawing.Size(45, 17);
            carbsLabel.TabIndex = 6;
            carbsLabel.Text = "Carbs";
            // 
            // fatTextBox
            // 
            fatTextBox.Enabled = false;
            fatTextBox.Location = new System.Drawing.Point(6, 261);
            fatTextBox.Name = "fatTextBox";
            fatTextBox.Size = new System.Drawing.Size(223, 22);
            fatTextBox.TabIndex = 9;
            // 
            // fatLabel
            // 
            fatLabel.AutoSize = true;
            fatLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            fatLabel.Location = new System.Drawing.Point(3, 241);
            fatLabel.Name = "fatLabel";
            fatLabel.Size = new System.Drawing.Size(28, 17);
            fatLabel.TabIndex = 8;
            fatLabel.Text = "Fat";
            // 
            // servingSizeTextBox
            // 
            servingSizeTextBox.Enabled = false;
            servingSizeTextBox.Location = new System.Drawing.Point(6, 78);
            servingSizeTextBox.Name = "servingSizeTextBox";
            servingSizeTextBox.Size = new System.Drawing.Size(223, 22);
            servingSizeTextBox.TabIndex = 11;
            // 
            // label14
            // 
            servingSizeLabel.AutoSize = true;
            servingSizeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            servingSizeLabel.Location = new System.Drawing.Point(3, 57);
            servingSizeLabel.Name = "servingSizeLabel";
            servingSizeLabel.Size = new System.Drawing.Size(87, 17);
            servingSizeLabel.TabIndex = 10;
            servingSizeLabel.Text = "Serving Size";
        }
    }
}
