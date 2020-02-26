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
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.databaseDataSet = new Nutrition_Facts.DatabaseDataSet();
            this.factsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factsTableAdapter = new Nutrition_Facts.DatabaseDataSetTableAdapters.FactsTableAdapter();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.extrasButton = new System.Windows.Forms.Button();
            this.searchB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.childPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factsBindingSource)).BeginInit();
            this.sideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "refresh.png");
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
            // sideMenuPanel
            // 
            this.sideMenuPanel.Controls.Add(this.extrasButton);
            this.sideMenuPanel.Controls.Add(this.searchB);
            this.sideMenuPanel.Controls.Add(this.button1);
            this.sideMenuPanel.Controls.Add(this.settingsButton);
            this.sideMenuPanel.Controls.Add(this.dashboardButton);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(250, 724);
            this.sideMenuPanel.TabIndex = 22;
            // 
            // extrasButton
            // 
            this.extrasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.extrasButton.FlatAppearance.BorderSize = 0;
            this.extrasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extrasButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasButton.Location = new System.Drawing.Point(0, 180);
            this.extrasButton.Name = "extrasButton";
            this.extrasButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.extrasButton.Size = new System.Drawing.Size(250, 90);
            this.extrasButton.TabIndex = 5;
            this.extrasButton.Text = "Extras";
            this.extrasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.extrasButton.UseVisualStyleBackColor = true;
            // 
            // searchB
            // 
            this.searchB.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchB.FlatAppearance.BorderSize = 0;
            this.searchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchB.Location = new System.Drawing.Point(0, 90);
            this.searchB.Name = "searchB";
            this.searchB.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.searchB.Size = new System.Drawing.Size(250, 90);
            this.searchB.TabIndex = 4;
            this.searchB.Text = "Search";
            this.searchB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 544);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 90);
            this.button1.TabIndex = 3;
            this.button1.Text = "Admin";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(0, 634);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settingsButton.Size = new System.Drawing.Size(250, 90);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.Location = new System.Drawing.Point(0, 0);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(250, 90);
            this.dashboardButton.TabIndex = 0;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // childPanel
            // 
            this.childPanel.BackColor = System.Drawing.Color.DarkGray;
            this.childPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childPanel.Location = new System.Drawing.Point(250, 0);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(1181, 724);
            this.childPanel.TabIndex = 23;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 724);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nutrition Facts";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factsBindingSource)).EndInit();
            this.sideMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource factsBindingSource;
        private DatabaseDataSetTableAdapters.FactsTableAdapter factsTableAdapter;
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button extrasButton;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Panel childPanel;
    }
}

