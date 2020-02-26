namespace Nutrition_Facts
{
    partial class SearchForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.calorieLabel = new System.Windows.Forms.Label();
            this.caloriebreakdownLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.servingUpdateButton = new System.Windows.Forms.Button();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.fatTextbox = new System.Windows.Forms.TextBox();
            this.servingSizeLabel = new System.Windows.Forms.Label();
            this.caloriesTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proteinTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carbTextbox = new System.Windows.Forms.TextBox();
            this.calorieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.searchButton = new System.Windows.Forms.Button();
            this.addMealButton = new System.Windows.Forms.Button();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calorieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox5.Controls.Add(this.calorieLabel);
            this.groupBox5.Controls.Add(this.caloriebreakdownLabel);
            this.groupBox5.Location = new System.Drawing.Point(527, 340);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(360, 107);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Calorie Breakdown";
            // 
            // calorieLabel
            // 
            this.calorieLabel.AutoSize = true;
            this.calorieLabel.Location = new System.Drawing.Point(6, 22);
            this.calorieLabel.Name = "calorieLabel";
            this.calorieLabel.Size = new System.Drawing.Size(84, 17);
            this.calorieLabel.TabIndex = 13;
            this.calorieLabel.Text = "calorie label";
            // 
            // caloriebreakdownLabel
            // 
            this.caloriebreakdownLabel.AutoSize = true;
            this.caloriebreakdownLabel.Location = new System.Drawing.Point(6, 65);
            this.caloriebreakdownLabel.Name = "caloriebreakdownLabel";
            this.caloriebreakdownLabel.Size = new System.Drawing.Size(157, 17);
            this.caloriebreakdownLabel.TabIndex = 14;
            this.caloriebreakdownLabel.Text = "calorie breakdown label";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.servingUpdateButton);
            this.groupBox2.Controls.Add(this.quantityTextbox);
            this.groupBox2.Controls.Add(this.fatTextbox);
            this.groupBox2.Controls.Add(this.servingSizeLabel);
            this.groupBox2.Controls.Add(this.caloriesTextbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.proteinTextbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.carbTextbox);
            this.groupBox2.Location = new System.Drawing.Point(527, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 229);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nutrition Summary";
            // 
            // servingUpdateButton
            // 
            this.servingUpdateButton.AutoSize = true;
            this.servingUpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.servingUpdateButton.BackColor = System.Drawing.SystemColors.Menu;
            this.servingUpdateButton.Location = new System.Drawing.Point(241, 127);
            this.servingUpdateButton.Name = "servingUpdateButton";
            this.servingUpdateButton.Size = new System.Drawing.Size(64, 27);
            this.servingUpdateButton.TabIndex = 17;
            this.servingUpdateButton.Text = "Update";
            this.servingUpdateButton.UseVisualStyleBackColor = false;
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextbox.Location = new System.Drawing.Point(6, 47);
            this.quantityTextbox.Multiline = true;
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(111, 52);
            this.quantityTextbox.TabIndex = 3;
            this.quantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fatTextbox
            // 
            this.fatTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatTextbox.Location = new System.Drawing.Point(123, 129);
            this.fatTextbox.Multiline = true;
            this.fatTextbox.Name = "fatTextbox";
            this.fatTextbox.ReadOnly = true;
            this.fatTextbox.Size = new System.Drawing.Size(112, 52);
            this.fatTextbox.TabIndex = 7;
            this.fatTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // servingSizeLabel
            // 
            this.servingSizeLabel.AutoSize = true;
            this.servingSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.servingSizeLabel.Location = new System.Drawing.Point(2, 20);
            this.servingSizeLabel.Name = "servingSizeLabel";
            this.servingSizeLabel.Size = new System.Drawing.Size(122, 24);
            this.servingSizeLabel.TabIndex = 8;
            this.servingSizeLabel.Text = "Serving Size*";
            // 
            // caloriesTextbox
            // 
            this.caloriesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesTextbox.Location = new System.Drawing.Point(123, 47);
            this.caloriesTextbox.Multiline = true;
            this.caloriesTextbox.Name = "caloriesTextbox";
            this.caloriesTextbox.ReadOnly = true;
            this.caloriesTextbox.Size = new System.Drawing.Size(112, 52);
            this.caloriesTextbox.TabIndex = 4;
            this.caloriesTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label5.Location = new System.Drawing.Point(157, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label4.Location = new System.Drawing.Point(33, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Carb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label2.Location = new System.Drawing.Point(145, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Calories";
            // 
            // proteinTextbox
            // 
            this.proteinTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinTextbox.Location = new System.Drawing.Point(241, 47);
            this.proteinTextbox.Multiline = true;
            this.proteinTextbox.Name = "proteinTextbox";
            this.proteinTextbox.ReadOnly = true;
            this.proteinTextbox.Size = new System.Drawing.Size(112, 52);
            this.proteinTextbox.TabIndex = 5;
            this.proteinTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label3.Location = new System.Drawing.Point(263, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Protein";
            // 
            // carbTextbox
            // 
            this.carbTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbTextbox.Location = new System.Drawing.Point(6, 129);
            this.carbTextbox.Multiline = true;
            this.carbTextbox.Name = "carbTextbox";
            this.carbTextbox.ReadOnly = true;
            this.carbTextbox.Size = new System.Drawing.Size(111, 52);
            this.carbTextbox.TabIndex = 6;
            this.carbTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calorieChart
            // 
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 0;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.BackColor = System.Drawing.SystemColors.ScrollBar;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent90;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Black;
            this.calorieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.calorieChart.Legends.Add(legend1);
            this.calorieChart.Location = new System.Drawing.Point(527, 453);
            this.calorieChart.Name = "calorieChart";
            this.calorieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ShadowColor = System.Drawing.Color.DimGray;
            this.calorieChart.Series.Add(series1);
            this.calorieChart.Size = new System.Drawing.Size(360, 184);
            this.calorieChart.TabIndex = 26;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(463, 62);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 30);
            this.searchButton.TabIndex = 22;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addMealButton
            // 
            this.addMealButton.AutoSize = true;
            this.addMealButton.Enabled = false;
            this.addMealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMealButton.Image = ((System.Drawing.Image)(resources.GetObject("addMealButton.Image")));
            this.addMealButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addMealButton.Location = new System.Drawing.Point(177, 340);
            this.addMealButton.Name = "addMealButton";
            this.addMealButton.Size = new System.Drawing.Size(104, 43);
            this.addMealButton.TabIndex = 29;
            this.addMealButton.Text = "Add";
            this.addMealButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMealButton.UseVisualStyleBackColor = false;
            // 
            // inputTextbox
            // 
            this.inputTextbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.inputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.inputTextbox.Location = new System.Drawing.Point(180, 64);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(296, 23);
            this.inputTextbox.TabIndex = 21;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Felix Titling", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(177, 105);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox.Size = new System.Drawing.Size(316, 229);
            this.listBox.TabIndex = 23;
            // 
            // refreshButton
            // 
            this.refreshButton.AutoSize = true;
            this.refreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ImageIndex = 0;
            this.refreshButton.Location = new System.Drawing.Point(494, 117);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(8, 8);
            this.refreshButton.TabIndex = 24;
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 677);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.calorieChart);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addMealButton);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.refreshButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calorieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label calorieLabel;
        private System.Windows.Forms.Label caloriebreakdownLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button servingUpdateButton;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.TextBox fatTextbox;
        private System.Windows.Forms.Label servingSizeLabel;
        private System.Windows.Forms.TextBox caloriesTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proteinTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox carbTextbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart calorieChart;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addMealButton;
        private System.Windows.Forms.TextBox inputTextbox;
        public System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button refreshButton;
    }
}