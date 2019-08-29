namespace Nutrition_Facts
{
    partial class Messaging
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
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.numberTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTextbox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.emailButton = new System.Windows.Forms.Button();
            this.attachButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.attachTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextbox = new System.Windows.Forms.TextBox();
            this.toTextbox = new System.Windows.Forms.TextBox();
            this.passwordEmailTextbox = new System.Windows.Forms.TextBox();
            this.fromTextbox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.toNumberTextbox = new System.Windows.Forms.TextBox();
            this.eventLogTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(130, 18);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(170, 22);
            this.nameTextbox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(130, 56);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(170, 22);
            this.passwordTextbox.TabIndex = 1;
            // 
            // numberTextbox
            // 
            this.numberTextbox.Location = new System.Drawing.Point(130, 98);
            this.numberTextbox.Name = "numberTextbox";
            this.numberTextbox.Size = new System.Drawing.Size(170, 22);
            this.numberTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Text";
            // 
            // textTextbox
            // 
            this.textTextbox.Location = new System.Drawing.Point(130, 191);
            this.textTextbox.Multiline = true;
            this.textTextbox.Name = "textTextbox";
            this.textTextbox.Size = new System.Drawing.Size(170, 117);
            this.textTextbox.TabIndex = 7;
            // 
            // sendButton
            // 
            this.sendButton.AutoSize = true;
            this.sendButton.Location = new System.Drawing.Point(348, 281);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(112, 27);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Send Message";
            this.sendButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(39, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 442);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Whatsapp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.eventLogTextbox);
            this.groupBox3.Controls.Add(this.toNumberTextbox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.nameTextbox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.sendButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.passwordTextbox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textTextbox);
            this.groupBox3.Controls.Add(this.numberTextbox);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 338);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.emailButton);
            this.groupBox2.Controls.Add(this.attachButton);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.attachTextbox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bodyTextBox);
            this.groupBox2.Controls.Add(this.subjectTextbox);
            this.groupBox2.Controls.Add(this.toTextbox);
            this.groupBox2.Controls.Add(this.passwordEmailTextbox);
            this.groupBox2.Controls.Add(this.fromTextbox);
            this.groupBox2.Location = new System.Drawing.Point(576, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 442);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Email";
            // 
            // emailButton
            // 
            this.emailButton.AutoSize = true;
            this.emailButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emailButton.Location = new System.Drawing.Point(343, 394);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(89, 27);
            this.emailButton.TabIndex = 9;
            this.emailButton.Text = "Send Email";
            this.emailButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailButton.UseVisualStyleBackColor = true;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // attachButton
            // 
            this.attachButton.AutoSize = true;
            this.attachButton.Location = new System.Drawing.Point(374, 19);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(58, 27);
            this.attachButton.TabIndex = 9;
            this.attachButton.Text = "Attach";
            this.attachButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.attachButton.UseVisualStyleBackColor = true;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Attachment";
            // 
            // attachTextbox
            // 
            this.attachTextbox.Location = new System.Drawing.Point(133, 21);
            this.attachTextbox.Name = "attachTextbox";
            this.attachTextbox.ReadOnly = true;
            this.attachTextbox.Size = new System.Drawing.Size(235, 22);
            this.attachTextbox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Body";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Subject";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "From";
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Location = new System.Drawing.Point(133, 166);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(299, 222);
            this.bodyTextBox.TabIndex = 13;
            // 
            // subjectTextbox
            // 
            this.subjectTextbox.Location = new System.Drawing.Point(133, 138);
            this.subjectTextbox.Name = "subjectTextbox";
            this.subjectTextbox.Size = new System.Drawing.Size(299, 22);
            this.subjectTextbox.TabIndex = 12;
            // 
            // toTextbox
            // 
            this.toTextbox.Location = new System.Drawing.Point(133, 110);
            this.toTextbox.Name = "toTextbox";
            this.toTextbox.Size = new System.Drawing.Size(299, 22);
            this.toTextbox.TabIndex = 11;
            // 
            // passwordEmailTextbox
            // 
            this.passwordEmailTextbox.Location = new System.Drawing.Point(133, 82);
            this.passwordEmailTextbox.Name = "passwordEmailTextbox";
            this.passwordEmailTextbox.PasswordChar = '*';
            this.passwordEmailTextbox.Size = new System.Drawing.Size(299, 22);
            this.passwordEmailTextbox.TabIndex = 10;
            // 
            // fromTextbox
            // 
            this.fromTextbox.Location = new System.Drawing.Point(133, 54);
            this.fromTextbox.Name = "fromTextbox";
            this.fromTextbox.Size = new System.Drawing.Size(299, 22);
            this.fromTextbox.TabIndex = 9;
            this.fromTextbox.Text = "ahmetince1996fb@hotmail.com";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "To";
            // 
            // toNumberTextbox
            // 
            this.toNumberTextbox.Location = new System.Drawing.Point(130, 139);
            this.toNumberTextbox.Name = "toNumberTextbox";
            this.toNumberTextbox.Size = new System.Drawing.Size(170, 22);
            this.toNumberTextbox.TabIndex = 10;
            // 
            // eventLogTextbox
            // 
            this.eventLogTextbox.Location = new System.Drawing.Point(348, 56);
            this.eventLogTextbox.Multiline = true;
            this.eventLogTextbox.Name = "eventLogTextbox";
            this.eventLogTextbox.Size = new System.Drawing.Size(112, 181);
            this.eventLogTextbox.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(345, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Event Log";
            // 
            // Messaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Messaging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendSMS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox numberTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTextbox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox attachTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.TextBox subjectTextbox;
        private System.Windows.Forms.TextBox toTextbox;
        private System.Windows.Forms.TextBox passwordEmailTextbox;
        private System.Windows.Forms.TextBox fromTextbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox toNumberTextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox eventLogTextbox;
    }
}