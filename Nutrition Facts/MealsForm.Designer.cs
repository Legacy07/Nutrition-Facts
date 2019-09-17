namespace Nutrition_Facts
{
    partial class MealsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabLayout = new System.Windows.Forms.TabControl();
            this.breakfastTab = new System.Windows.Forms.TabPage();
            this.lunchTab = new System.Windows.Forms.TabPage();
            this.dinnerTab = new System.Windows.Forms.TabPage();
            this.snackTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calorieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ptotalNutrientsPanel = new System.Windows.Forms.Panel();
            this.mealPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.mealNameTextBox = new System.Windows.Forms.TextBox();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.proteinTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.carbsTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.servingSizeTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tabLayout.SuspendLayout();
            this.breakfastTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calorieChart)).BeginInit();
            this.ptotalNutrientsPanel.SuspendLayout();
            this.mealPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayout
            // 
            this.tabLayout.Controls.Add(this.breakfastTab);
            this.tabLayout.Controls.Add(this.lunchTab);
            this.tabLayout.Controls.Add(this.dinnerTab);
            this.tabLayout.Controls.Add(this.snackTab);
            this.tabLayout.Location = new System.Drawing.Point(12, 12);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            this.tabLayout.Size = new System.Drawing.Size(920, 360);
            this.tabLayout.TabIndex = 0;
            // 
            // breakfastTab
            // 
            this.breakfastTab.Controls.Add(this.vScrollBar1);
            this.breakfastTab.Controls.Add(this.mealPanel);
            this.breakfastTab.Location = new System.Drawing.Point(4, 25);
            this.breakfastTab.Name = "breakfastTab";
            this.breakfastTab.Padding = new System.Windows.Forms.Padding(3);
            this.breakfastTab.Size = new System.Drawing.Size(912, 331);
            this.breakfastTab.TabIndex = 0;
            this.breakfastTab.Text = "Breakfast";
            this.breakfastTab.UseVisualStyleBackColor = true;
            // 
            // lunchTab
            // 
            this.lunchTab.Location = new System.Drawing.Point(4, 25);
            this.lunchTab.Name = "lunchTab";
            this.lunchTab.Padding = new System.Windows.Forms.Padding(3);
            this.lunchTab.Size = new System.Drawing.Size(912, 331);
            this.lunchTab.TabIndex = 1;
            this.lunchTab.Text = "Lunch";
            this.lunchTab.UseVisualStyleBackColor = true;
            // 
            // dinnerTab
            // 
            this.dinnerTab.Location = new System.Drawing.Point(4, 25);
            this.dinnerTab.Name = "dinnerTab";
            this.dinnerTab.Size = new System.Drawing.Size(912, 295);
            this.dinnerTab.TabIndex = 2;
            this.dinnerTab.Text = "Dinner";
            this.dinnerTab.UseVisualStyleBackColor = true;
            // 
            // snackTab
            // 
            this.snackTab.Location = new System.Drawing.Point(4, 25);
            this.snackTab.Name = "snackTab";
            this.snackTab.Size = new System.Drawing.Size(912, 295);
            this.snackTab.TabIndex = 3;
            this.snackTab.Text = "Snacks";
            this.snackTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Calories in numbers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Protein";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Protein in numbers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Carbs in numbers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Carbs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(928, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Fat in numbers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(858, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total Fat";
            // 
            // calorieChart
            // 
            chartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea4.Area3DStyle.Enable3D = true;
            chartArea4.Area3DStyle.Inclination = 0;
            chartArea4.Area3DStyle.IsRightAngleAxes = false;
            chartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea4.BackColor = System.Drawing.SystemColors.ScrollBar;
            chartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent90;
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.BorderWidth = 0;
            chartArea4.Name = "ChartArea1";
            chartArea4.ShadowColor = System.Drawing.Color.Black;
            this.calorieChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.calorieChart.Legends.Add(legend4);
            this.calorieChart.Location = new System.Drawing.Point(938, 37);
            this.calorieChart.Name = "calorieChart";
            this.calorieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.BorderColor = System.Drawing.Color.White;
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.ShadowColor = System.Drawing.Color.DimGray;
            this.calorieChart.Series.Add(series4);
            this.calorieChart.Size = new System.Drawing.Size(399, 295);
            this.calorieChart.TabIndex = 18;
            // 
            // ptotalNutrientsPanel
            // 
            this.ptotalNutrientsPanel.Controls.Add(this.label1);
            this.ptotalNutrientsPanel.Controls.Add(this.label7);
            this.ptotalNutrientsPanel.Controls.Add(this.label4);
            this.ptotalNutrientsPanel.Controls.Add(this.label6);
            this.ptotalNutrientsPanel.Controls.Add(this.label2);
            this.ptotalNutrientsPanel.Controls.Add(this.label5);
            this.ptotalNutrientsPanel.Controls.Add(this.label3);
            this.ptotalNutrientsPanel.Controls.Add(this.label8);
            this.ptotalNutrientsPanel.Location = new System.Drawing.Point(16, 378);
            this.ptotalNutrientsPanel.Name = "ptotalNutrientsPanel";
            this.ptotalNutrientsPanel.Size = new System.Drawing.Size(912, 60);
            this.ptotalNutrientsPanel.TabIndex = 19;
            // 
            // mealPanel
            // 
            this.mealPanel.BackColor = System.Drawing.Color.DimGray;
            this.mealPanel.Controls.Add(this.servingSizeTextBox);
            this.mealPanel.Controls.Add(this.label9);
            this.mealPanel.Controls.Add(this.mealNameTextBox);
            this.mealPanel.Controls.Add(this.label14);
            this.mealPanel.Controls.Add(this.fatTextBox);
            this.mealPanel.Controls.Add(this.label13);
            this.mealPanel.Controls.Add(this.carbsTextBox);
            this.mealPanel.Controls.Add(this.label12);
            this.mealPanel.Controls.Add(this.proteinTextBox);
            this.mealPanel.Controls.Add(this.label11);
            this.mealPanel.Controls.Add(this.caloriesTextBox);
            this.mealPanel.Controls.Add(this.label10);
            this.mealPanel.Location = new System.Drawing.Point(6, 15);
            this.mealPanel.Name = "mealPanel";
            this.mealPanel.Size = new System.Drawing.Size(232, 301);
            this.mealPanel.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Meal";
            // 
            // mealNameTextBox
            // 
            this.mealNameTextBox.Enabled = false;
            this.mealNameTextBox.Location = new System.Drawing.Point(6, 32);
            this.mealNameTextBox.Name = "mealNameTextBox";
            this.mealNameTextBox.Size = new System.Drawing.Size(223, 22);
            this.mealNameTextBox.TabIndex = 1;
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Enabled = false;
            this.caloriesTextBox.Location = new System.Drawing.Point(6, 123);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(223, 22);
            this.caloriesTextBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(3, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Calories";
            // 
            // proteinTextBox
            // 
            this.proteinTextBox.Enabled = false;
            this.proteinTextBox.Location = new System.Drawing.Point(6, 169);
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(223, 22);
            this.proteinTextBox.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(3, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Protein";
            // 
            // carbsTextBox
            // 
            this.carbsTextBox.Enabled = false;
            this.carbsTextBox.Location = new System.Drawing.Point(6, 215);
            this.carbsTextBox.Name = "carbsTextBox";
            this.carbsTextBox.Size = new System.Drawing.Size(223, 22);
            this.carbsTextBox.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(3, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Carbs";
            // 
            // fatTextBox
            // 
            this.fatTextBox.Enabled = false;
            this.fatTextBox.Location = new System.Drawing.Point(6, 261);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(223, 22);
            this.fatTextBox.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(3, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Fat";
            // 
            // servingSizeTextBox
            // 
            this.servingSizeTextBox.Enabled = false;
            this.servingSizeTextBox.Location = new System.Drawing.Point(6, 78);
            this.servingSizeTextBox.Name = "servingSizeTextBox";
            this.servingSizeTextBox.Size = new System.Drawing.Size(223, 22);
            this.servingSizeTextBox.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(3, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Serving Size";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(889, 3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 325);
            this.vScrollBar1.TabIndex = 1;
            // 
            // MealsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 470);
            this.Controls.Add(this.ptotalNutrientsPanel);
            this.Controls.Add(this.calorieChart);
            this.Controls.Add(this.tabLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MealsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meals";
            this.tabLayout.ResumeLayout(false);
            this.breakfastTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calorieChart)).EndInit();
            this.ptotalNutrientsPanel.ResumeLayout(false);
            this.ptotalNutrientsPanel.PerformLayout();
            this.mealPanel.ResumeLayout(false);
            this.mealPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLayout;
        private System.Windows.Forms.TabPage breakfastTab;
        private System.Windows.Forms.TabPage lunchTab;
        private System.Windows.Forms.TabPage dinnerTab;
        private System.Windows.Forms.TabPage snackTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart calorieChart;
        private System.Windows.Forms.Panel ptotalNutrientsPanel;
        private System.Windows.Forms.Panel mealPanel;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox carbsTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox proteinTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mealNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox servingSizeTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}