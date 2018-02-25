namespace Nutrition_Facts
{
    partial class Add
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fatLabel = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.carbLabel = new System.Windows.Forms.Label();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.fatTextbox = new System.Windows.Forms.TextBox();
            this.carbTextBox = new System.Windows.Forms.TextBox();
            this.proteinTextbox = new System.Windows.Forms.TextBox();
            this.calorieTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fatLabel);
            this.groupBox2.Controls.Add(this.quantityTextbox);
            this.groupBox2.Controls.Add(this.carbLabel);
            this.groupBox2.Controls.Add(this.proteinLabel);
            this.groupBox2.Controls.Add(this.caloriesLabel);
            this.groupBox2.Controls.Add(this.quantityLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.fatTextbox);
            this.groupBox2.Controls.Add(this.carbTextBox);
            this.groupBox2.Controls.Add(this.proteinTextbox);
            this.groupBox2.Controls.Add(this.calorieTextbox);
            this.groupBox2.Controls.Add(this.nameTextbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(133, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 211);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(6, 161);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(33, 20);
            this.fatLabel.TabIndex = 14;
            this.fatLabel.Text = "Fat";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(130, 49);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.ShortcutsEnabled = false;
            this.quantityTextbox.Size = new System.Drawing.Size(178, 26);
            this.quantityTextbox.TabIndex = 13;
            this.quantityTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextbox_KeyPress);
            // 
            // carbLabel
            // 
            this.carbLabel.AutoSize = true;
            this.carbLabel.Location = new System.Drawing.Point(6, 132);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(109, 20);
            this.carbLabel.TabIndex = 12;
            this.carbLabel.Text = "Carbohydrate";
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Location = new System.Drawing.Point(7, 105);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(62, 20);
            this.proteinLabel.TabIndex = 11;
            this.proteinLabel.Text = "Protein";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(7, 77);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(71, 20);
            this.caloriesLabel.TabIndex = 10;
            this.caloriesLabel.Text = "Calories";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(6, 49);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(71, 20);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Location = new System.Drawing.Point(361, 160);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(48, 30);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // fatTextbox
            // 
            this.fatTextbox.Location = new System.Drawing.Point(130, 162);
            this.fatTextbox.Name = "fatTextbox";
            this.fatTextbox.ShortcutsEnabled = false;
            this.fatTextbox.Size = new System.Drawing.Size(178, 26);
            this.fatTextbox.TabIndex = 5;
            this.fatTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fatTextbox_KeyPress);
            // 
            // carbTextBox
            // 
            this.carbTextBox.Location = new System.Drawing.Point(130, 133);
            this.carbTextBox.Name = "carbTextBox";
            this.carbTextBox.ShortcutsEnabled = false;
            this.carbTextBox.Size = new System.Drawing.Size(178, 26);
            this.carbTextBox.TabIndex = 4;
            this.carbTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carbTextBox_KeyPress);
            // 
            // proteinTextbox
            // 
            this.proteinTextbox.Location = new System.Drawing.Point(130, 105);
            this.proteinTextbox.Name = "proteinTextbox";
            this.proteinTextbox.ShortcutsEnabled = false;
            this.proteinTextbox.Size = new System.Drawing.Size(178, 26);
            this.proteinTextbox.TabIndex = 3;
            this.proteinTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proteinTextbox_KeyPress);
            // 
            // calorieTextbox
            // 
            this.calorieTextbox.Location = new System.Drawing.Point(130, 77);
            this.calorieTextbox.Name = "calorieTextbox";
            this.calorieTextbox.ShortcutsEnabled = false;
            this.calorieTextbox.Size = new System.Drawing.Size(178, 26);
            this.calorieTextbox.TabIndex = 2;
            this.calorieTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calorieTextbox_KeyPress);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(130, 21);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.ShortcutsEnabled = false;
            this.nameTextbox.Size = new System.Drawing.Size(178, 26);
            this.nameTextbox.TabIndex = 1;
            this.nameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextbox_KeyPress);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 341);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Label carbLabel;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox fatTextbox;
        private System.Windows.Forms.TextBox carbTextBox;
        private System.Windows.Forms.TextBox proteinTextbox;
        private System.Windows.Forms.TextBox calorieTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
    }
}