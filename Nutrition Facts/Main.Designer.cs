namespace Nutrition_Facts
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.showMealsButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.calorieLabel = new System.Windows.Forms.Label();
            this.caloriebreakdownLabel = new System.Windows.Forms.Label();
            this.addMealButton = new System.Windows.Forms.Button();
            this.searchFoodLabel = new System.Windows.Forms.Label();
            this.calorieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMRCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.databaseDataSet = new Nutrition_Facts.DatabaseDataSet();
            this.factsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factsTableAdapter = new Nutrition_Facts.DatabaseDataSetTableAdapters.FactsTableAdapter();
            this.groupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calorieChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextbox
            // 
            this.inputTextbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.inputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.inputTextbox.Location = new System.Drawing.Point(517, 61);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(296, 23);
            this.inputTextbox.TabIndex = 0;
            this.inputTextbox.TextChanged += new System.EventHandler(this.inputTextbox_TextChanged);
            this.inputTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextbox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(782, 58);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 30);
            this.searchButton.TabIndex = 1;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.showMealsButton);
            this.groupBox.Controls.Add(this.groupBox5);
            this.groupBox.Controls.Add(this.searchButton);
            this.groupBox.Controls.Add(this.addMealButton);
            this.groupBox.Controls.Add(this.searchFoodLabel);
            this.groupBox.Controls.Add(this.calorieChart);
            this.groupBox.Controls.Add(this.groupBox2);
            this.groupBox.Controls.Add(this.refreshButton);
            this.groupBox.Controls.Add(this.listBox);
            this.groupBox.Controls.Add(this.inputTextbox);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(12, 58);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1338, 667);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // showMealsButton
            // 
            this.showMealsButton.AutoSize = true;
            this.showMealsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMealsButton.Location = new System.Drawing.Point(1114, 20);
            this.showMealsButton.Name = "showMealsButton";
            this.showMealsButton.Size = new System.Drawing.Size(155, 95);
            this.showMealsButton.TabIndex = 21;
            this.showMealsButton.Text = "Show Meals";
            this.showMealsButton.UseVisualStyleBackColor = false;
            this.showMealsButton.Click += new System.EventHandler(this.showMealsButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox5.Controls.Add(this.calorieLabel);
            this.groupBox5.Controls.Add(this.caloriebreakdownLabel);
            this.groupBox5.Location = new System.Drawing.Point(894, 373);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 267);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Calorie Breakdown";
            // 
            // calorieLabel
            // 
            this.calorieLabel.AutoSize = true;
            this.calorieLabel.Location = new System.Drawing.Point(6, 22);
            this.calorieLabel.Name = "calorieLabel";
            this.calorieLabel.Size = new System.Drawing.Size(99, 20);
            this.calorieLabel.TabIndex = 13;
            this.calorieLabel.Text = "calorie label";
            // 
            // caloriebreakdownLabel
            // 
            this.caloriebreakdownLabel.AutoSize = true;
            this.caloriebreakdownLabel.Location = new System.Drawing.Point(6, 65);
            this.caloriebreakdownLabel.Name = "caloriebreakdownLabel";
            this.caloriebreakdownLabel.Size = new System.Drawing.Size(184, 20);
            this.caloriebreakdownLabel.TabIndex = 14;
            this.caloriebreakdownLabel.Text = "calorie breakdown label";
            // 
            // addMealButton
            // 
            this.addMealButton.AutoSize = true;
            this.addMealButton.Enabled = false;
            this.addMealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMealButton.Image = ((System.Drawing.Image)(resources.GetObject("addMealButton.Image")));
            this.addMealButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addMealButton.Location = new System.Drawing.Point(819, 49);
            this.addMealButton.Name = "addMealButton";
            this.addMealButton.Size = new System.Drawing.Size(104, 43);
            this.addMealButton.TabIndex = 20;
            this.addMealButton.Text = "Add";
            this.addMealButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMealButton.UseVisualStyleBackColor = false;
            this.addMealButton.Click += new System.EventHandler(this.addMealButton_Click);
            // 
            // searchFoodLabel
            // 
            this.searchFoodLabel.AutoSize = true;
            this.searchFoodLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFoodLabel.Location = new System.Drawing.Point(538, 17);
            this.searchFoodLabel.Name = "searchFoodLabel";
            this.searchFoodLabel.Size = new System.Drawing.Size(258, 41);
            this.searchFoodLabel.TabIndex = 19;
            this.searchFoodLabel.Text = "Search for Food";
            // 
            // calorieChart
            // 
            chartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.Inclination = 0;
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea3.BackColor = System.Drawing.SystemColors.ScrollBar;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent90;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.BorderWidth = 0;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.Black;
            this.calorieChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.calorieChart.Legends.Add(legend3);
            this.calorieChart.Location = new System.Drawing.Point(51, 373);
            this.calorieChart.Name = "calorieChart";
            this.calorieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.BorderColor = System.Drawing.Color.White;
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ShadowColor = System.Drawing.Color.DimGray;
            this.calorieChart.Series.Add(series3);
            this.calorieChart.Size = new System.Drawing.Size(399, 267);
            this.calorieChart.TabIndex = 17;
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
            this.groupBox2.Location = new System.Drawing.Point(490, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 267);
            this.groupBox2.TabIndex = 14;
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
            this.servingUpdateButton.Size = new System.Drawing.Size(72, 30);
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
            this.quantityTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextbox_KeyPress);
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
            // refreshButton
            // 
            this.refreshButton.AutoSize = true;
            this.refreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ImageIndex = 0;
            this.refreshButton.ImageList = this.imageList;
            this.refreshButton.Location = new System.Drawing.Point(385, 98);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(24, 24);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "refresh.png");
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Felix Titling", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(415, 98);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox.Size = new System.Drawing.Size(508, 229);
            this.listBox.TabIndex = 2;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backupDataToolStripMenuItem
            // 
            this.backupDataToolStripMenuItem.Name = "backupDataToolStripMenuItem";
            this.backupDataToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.backupDataToolStripMenuItem.Text = "Backup Data";
            this.backupDataToolStripMenuItem.Click += new System.EventHandler(this.backupDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMRCalculatorToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // bMRCalculatorToolStripMenuItem
            // 
            this.bMRCalculatorToolStripMenuItem.Name = "bMRCalculatorToolStripMenuItem";
            this.bMRCalculatorToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.bMRCalculatorToolStripMenuItem.Text = "BMR Calculator";
            this.bMRCalculatorToolStripMenuItem.Click += new System.EventHandler(this.bMRCalculatorToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFoodTypeToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // addFoodTypeToolStripMenuItem
            // 
            this.addFoodTypeToolStripMenuItem.Name = "addFoodTypeToolStripMenuItem";
            this.addFoodTypeToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.addFoodTypeToolStripMenuItem.Text = "Add Food Type";
            this.addFoodTypeToolStripMenuItem.Click += new System.EventHandler(this.addFoodTypeToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.updateToolStripMenuItem.Text = "Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Database";
            this.saveFileDialog.Filter = "Text Document|*.txt";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factsBindingSource
            // 
            this.factsBindingSource.DataMember = "Facts";
            this.factsBindingSource.DataSource = this.databaseDataSet;
            // 
            // factsTableAdapter
            // 
            this.factsTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 772);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nutrition Facts";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calorieChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label servingSizeLabel;
        private System.Windows.Forms.TextBox fatTextbox;
        private System.Windows.Forms.TextBox carbTextbox;
        private System.Windows.Forms.TextBox proteinTextbox;
        private System.Windows.Forms.TextBox caloriesTextbox;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Button refreshButton;
        public System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFoodTypeToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label calorieLabel;
        private System.Windows.Forms.Label caloriebreakdownLabel;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource factsBindingSource;
        private DatabaseDataSetTableAdapters.FactsTableAdapter factsTableAdapter;
        private System.Windows.Forms.Button servingUpdateButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem bMRCalculatorToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart calorieChart;
        private System.Windows.Forms.Label searchFoodLabel;
        private System.Windows.Forms.Button addMealButton;
        private System.Windows.Forms.Button showMealsButton;
    }
}

