namespace Nutrition_Facts
{
    partial class BMRForm
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
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.standardBMRRadioButton = new System.Windows.Forms.RadioButton();
            this.deficitRadioButton = new System.Windows.Forms.RadioButton();
            this.surplusRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(90, 21);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 22);
            this.weightTextBox.TabIndex = 0;
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightTextBox_KeyPress);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(90, 49);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 22);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextBox_KeyPress);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(90, 77);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 22);
            this.ageTextBox.TabIndex = 2;
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputLabel);
            this.groupBox1.Controls.Add(this.ageLabel);
            this.groupBox1.Controls.Add(this.heightLabel);
            this.groupBox1.Controls.Add(this.weightLabel);
            this.groupBox1.Controls.Add(this.standardBMRRadioButton);
            this.groupBox1.Controls.Add(this.deficitRadioButton);
            this.groupBox1.Controls.Add(this.surplusRadioButton);
            this.groupBox1.Controls.Add(this.calculateButton);
            this.groupBox1.Controls.Add(this.weightTextBox);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(this.heightTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMR Calculator";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(7, 77);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(38, 17);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "Age*";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(7, 49);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(54, 17);
            this.heightLabel.TabIndex = 8;
            this.heightLabel.Text = "Height*";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(7, 21);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(57, 17);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Weight*";
            // 
            // standardBMRRadioButton
            // 
            this.standardBMRRadioButton.AutoSize = true;
            this.standardBMRRadioButton.Location = new System.Drawing.Point(90, 106);
            this.standardBMRRadioButton.Name = "standardBMRRadioButton";
            this.standardBMRRadioButton.Size = new System.Drawing.Size(121, 21);
            this.standardBMRRadioButton.TabIndex = 6;
            this.standardBMRRadioButton.TabStop = true;
            this.standardBMRRadioButton.Text = "Standard BMR";
            this.standardBMRRadioButton.UseVisualStyleBackColor = true;
            // 
            // deficitRadioButton
            // 
            this.deficitRadioButton.AutoSize = true;
            this.deficitRadioButton.Location = new System.Drawing.Point(90, 159);
            this.deficitRadioButton.Name = "deficitRadioButton";
            this.deficitRadioButton.Size = new System.Drawing.Size(68, 21);
            this.deficitRadioButton.TabIndex = 5;
            this.deficitRadioButton.TabStop = true;
            this.deficitRadioButton.Text = "Deficit";
            this.deficitRadioButton.UseVisualStyleBackColor = true;
            // 
            // surplusRadioButton
            // 
            this.surplusRadioButton.AutoSize = true;
            this.surplusRadioButton.Location = new System.Drawing.Point(90, 133);
            this.surplusRadioButton.Name = "surplusRadioButton";
            this.surplusRadioButton.Size = new System.Drawing.Size(77, 21);
            this.surplusRadioButton.TabIndex = 4;
            this.surplusRadioButton.TabStop = true;
            this.surplusRadioButton.Text = "Surplus";
            this.surplusRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Location = new System.Drawing.Point(234, 151);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(78, 29);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(299, 18);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(13, 17);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "-";
            // 
            // BMRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 246);
            this.Controls.Add(this.groupBox1);
            this.Name = "BMRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basal Metabolic Rate Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.RadioButton standardBMRRadioButton;
        private System.Windows.Forms.RadioButton deficitRadioButton;
        private System.Windows.Forms.RadioButton surplusRadioButton;
        private System.Windows.Forms.Label outputLabel;
    }
}