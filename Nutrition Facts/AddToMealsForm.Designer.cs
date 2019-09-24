namespace Nutrition_Facts
{
    partial class AddToMealsForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMealButton = new System.Windows.Forms.Button();
            this.mealLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Snack"});
            this.comboBox1.Location = new System.Drawing.Point(12, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "For what meal?";
            // 
            // addMealButton
            // 
            this.addMealButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addMealButton.Location = new System.Drawing.Point(0, 104);
            this.addMealButton.Name = "addMealButton";
            this.addMealButton.Size = new System.Drawing.Size(394, 38);
            this.addMealButton.TabIndex = 2;
            this.addMealButton.Text = "Add Meal";
            this.addMealButton.UseVisualStyleBackColor = true;
            this.addMealButton.Click += new System.EventHandler(this.addMealButton_Click);
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(12, 9);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(38, 17);
            this.mealLabel.TabIndex = 3;
            this.mealLabel.Text = "Meal";
            // 
            // AddToMealsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 142);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.addMealButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddToMealsForm";
            this.Text = "AddToMealsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMealButton;
        private System.Windows.Forms.Label mealLabel;
    }
}