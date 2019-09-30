using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Deployment.Application;

namespace Nutrition_Facts
{
    public partial class Main : Form
    {
        private UpdateCheckInfo info;

        public bool rdiReturn = false;

        private Repository Repository { get; set; }

        private CalorieBreakDownResults calorieBreakdownResult;

        private MealsForm mealsForm;

        private string selectedMealName;

        public Main()
        {
            InitializeComponent();
            this.Repository = new Repository();

            this.FillListbox();

            this.ToolTips();

            this.SetDefaultValues();

            this.mealsForm = new MealsForm();
        }

        private void SetDefaultValues()
        {
            //setting nutrition summary textbox to 0
            quantityTextbox.Text = "0";
            caloriesTextbox.Text = "0";
            proteinTextbox.Text = "0";
            carbTextbox.Text = "0";
            fatTextbox.Text = "0";
        }

        private void ToolTips()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(calorieChart, "Calorie breakdown to illustrate nutritions taken");
            tooltip.SetToolTip(servingSizeLabel, "* In grams");
            tooltip.SetToolTip(servingUpdateButton, "Update Serving Size");
            tooltip.SetToolTip(refreshButton, "Refresh Database Content");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string input = inputTextbox.Text;

            listBox.SelectedItems.Clear();
            if (input == string.Empty)
            {
                MessageBox.Show("It can't be left blank");
            }
            else
            {
                for (int i = listBox.Items.Count - 1; i >= 0; i--)
                {
                    if (listBox.Items[i].ToString().ToLower().Contains(input.ToLower()))
                    {
                        listBox.SetSelected(i, true);

                        this.selectedMealName = listBox.Items[i].ToString();

                        this.addMealButton.Enabled = true;
                    }
                }
            }
        }

        public void FillListbox()
        {
            listBox.Items.Clear();

            var foodsData = this.Repository.GetAllFoods();

            foreach (DataRow dr in foodsData.Rows)
            {
                listBox.Items.Add(dr["Name"].ToString());
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
            }
            else
            {
                var foodData = Repository.GetFood(listBox.SelectedItem.ToString());

                //just get the first index from fooddata instead? coz this should contain only the selected food tha is returned from repository.
                foreach (DataRow row in foodData.Rows)
                {
                    quantityTextbox.Text = row["Quantity"].ToString();
                    caloriesTextbox.Text = row["Calorie"].ToString();
                    proteinTextbox.Text = row["Protein"].ToString();
                    carbTextbox.Text = row["Carb"].ToString();
                    fatTextbox.Text = row["Fat"].ToString();
                }

                calorieLabel.Text = "There are " + caloriesTextbox.Text + " Calories in " + quantityTextbox.Text + " grams of " + Environment.NewLine + listBox.SelectedItem;

                calorieBreakdownResult = this.CalorieBreakdown(fatTextbox.Text, carbTextbox.Text, proteinTextbox.Text, caloriesTextbox.Text);

                caloriebreakdownLabel.Text = "Calorie breakdown:" + Environment.NewLine + calorieBreakdownResult.TotalProteinPercentage + "% Protein"
                    + Environment.NewLine + calorieBreakdownResult.TotalCarbPercentage
                    + "% Carbohydrate" + Environment.NewLine + calorieBreakdownResult.TotalFatPercentage + "% Fat";

                this.GenerateCalorieGraph();
            }
        }

        private void inputTextbox_TextChanged(object sender, EventArgs e)
        {
            //DataView filter = dt.DefaultView;
            //filter.RowFilter = ""
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            SqlConnection connection = DatabaseClass.GetConnection();

            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }

            string query = "Select Name from Facts";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                listBox.Items.Add(row["Name"].ToString());
            }

            connection.Close();
            MessageBox.Show("Data Refreshed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backupDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = DatabaseClass.GetConnection();

            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;

                //backup data from database into a text file
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    string query = "Select * from Facts";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            streamWriter.WriteLine("Name, Calorie, Protein, Carb, Fat, Quantity");
                            while (reader.Read())
                            {
                                streamWriter.WriteLine("");
                                streamWriter.Write(reader["Name"].ToString());
                                streamWriter.Write(", " + reader["Calorie"].ToString());
                                streamWriter.Write(", " + reader["Protein"].ToString());
                                streamWriter.Write(", " + reader["Carb"].ToString());
                                streamWriter.Write(", " + reader["Fat"].ToString());
                                streamWriter.Write(", " + reader["Quantity"].ToString());

                            }
                            streamWriter.WriteLine("");
                            streamWriter.WriteLine("---------------------------------");
                            streamWriter.WriteLine("Backup Generated at : " + DateTime.Now);
                            streamWriter.WriteLine("---------------------------------");
                            streamWriter.Close();
                            reader.Close();
                            MessageBox.Show("Backup Created!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Backup Cannot be Created!\n Error: " + ex.Message);
                        }
                    }
                }
            }
            connection.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void messagingServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addFoodTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFoodInDb add = new AddFoodInDb();
            add.ShowDialog();
        }

        //Updating the application before it starts and the user can manually check for updates also. 
        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment appDeploy = ApplicationDeployment.CurrentDeployment;
                //checking updates at the specified folder/server
                try
                {
                    info = appDeploy.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {

                    MessageBox.Show("Please check your network connection or try again later! Error Code: " + dde,
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidDeploymentException ide)
                {

                    MessageBox.Show("Please redeploy the application, unable to check for newer version! Error Code: " + ide,
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidOperationException ioe)
                {

                    MessageBox.Show("Unable to update, Likely to be a none Clickonce Application! Error Code: " + ioe,
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (info.UpdateAvailable)
                {
                    if (MessageBox.Show("A newer version is available, Update now?", "Message", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //upon available update, it updates and restarts the application
                        try
                        {
                            appDeploy.Update();
                            Application.Restart();
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("You're running the latest version!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Facts' table. You can move, or remove it, as needed.
            this.factsTableAdapter.Fill(this.databaseDataSet.Facts);
        }

        public void GenerateCalorieGraph()
        {
            calorieChart.Series[0].Points.Clear();

            if (caloriebreakdownLabel.Text == "")
            {
                MessageBox.Show("Please select a food type to generate the chart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    calorieChart.Series["Series"].Points.AddXY("Fat", calorieBreakdownResult.TotalFatPercentage);
                    calorieChart.Series["Series"].Points.AddXY("Protein", calorieBreakdownResult.TotalProteinPercentage);
                    calorieChart.Series["Series"].Points.AddXY("Carbohydrate", calorieBreakdownResult.TotalCarbPercentage);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error occured! " + exc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        ////public void GenerateRDIChart(int rdi, int calories)
        ////{
        ////    //if the input of RDI is bigger than calories then output the chart based on the input
        ////    if (decimal.Parse(rdi.ToString()) > decimal.Parse(calories.ToString()))
        ////    {
        ////        int finalRDI = int.Parse(rdi.ToString()) - int.Parse(calories.ToString());

        ////        rdiChart.Series[0].Points.Clear();

        ////        try
        ////        {
        ////            rdiChart.Series["Series"].Points.AddXY("RDI", finalRDI.ToString());
        ////            rdiChart.Series["Series"].Points.AddXY("Calories", calories.ToString());
        ////        }
        ////        catch (Exception exc)
        ////        {
        ////            MessageBox.Show("An error occured! " + exc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////        }
        ////    }
        ////}

        public decimal CalculateRDIPercentage(decimal rdi, decimal calories)
        {
            decimal percentage = (calories / rdi) * 100;
            return percentage;
        }

        public decimal PercentageOfAverageRDI(decimal calories)
        {
            decimal percentage = (calories / 2000) * 100;
            return percentage;
        }

        public bool RDICheck(decimal dailyDesiredIntake, decimal totalConsumedCalories)
        {
            //checking to see if the set rdi is smaller than the amout of calories
            if (dailyDesiredIntake < totalConsumedCalories)
            {
                MessageBox.Show("The amount of calories surpassed your daily intake, cannot output a chart!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rdiReturn = true;
            }
            return true;
        }

        //calculating the rdi and outputs a chart
        ////private void calculateButton_Click(object sender, EventArgs e)
        ////{
        ////    DialogResult result = MessageBox.Show("Are you calculating off the selected food type? If you trying to calculate from the meal calculator then select 'NO'!"
        ////        , "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        ////    //if rdi is smaller than calories then output a message
        ////    if (decimal.Parse(inputRdiTextBox.Text) < decimal.Parse(caloriesTextbox.Text))
        ////    {
        ////        //rdi check is true
        ////        RDICheck(decimal.Parse(inputRdiTextBox.Text), decimal.Parse(caloriesTextbox.Text));
        ////        //calorie surpassed so calculates the amount of the overdose
        ////        decimal surpass = Math.Round(CalorieSurpass(decimal.Parse(caloriesTextbox.Text), decimal.Parse(inputRdiTextBox.Text)));
        ////        rdiLabel.Text = "The amount of calorie intake have surpassed" + Environment.NewLine + " by %" + surpass.ToString();

        ////    }
        ////    //if selected yes then carry on 
        ////    else if (result == DialogResult.Yes)
        ////    {
        ////        //if the textbox is empty then output an error message
        ////        if (caloriesTextbox.Text == "" || inputRdiTextBox.Text == "")
        ////        {
        ////            MessageBox.Show("You haven't selected a food type or the input of your RDI is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////        }
        ////        else
        ////        //generate the chart
        ////        {

        ////            calorieLabel.Text = "There are " + caloriesTextbox.Text + " Calories in " + quantityTextbox.Text + " grams of " + Environment.NewLine + listBox.SelectedItem;
        ////            //using this method will tell us the the percentages of the calorie breakdown
        ////            CalorieBreakdown(fatTextbox.Text, carbTextbox.Text, proteinTextbox.Text, caloriesTextbox.Text);
        ////            //output
        ////            caloriebreakdownLabel.Text = "Calorie breakdown:" + Environment.NewLine + doubleTotalProteinPercentage + "% Protein"
        ////                + Environment.NewLine + doubleTotalCarbPercentage
        ////                + "% Carbohydrate" + Environment.NewLine + doubleTotalFatPercentage + "% Fat";
        ////            //generating calorie breakdown chart
        ////            GenerateCalorieGraph();
        ////            //rdi chart
        ////            GenerateRDIChart(int.Parse(inputRdiTextBox.Text), int.Parse(caloriesTextbox.Text));
        ////            decimal rdiPercentage = CalculateRDIPercentage(decimal.Parse(inputRdiTextBox.Text), decimal.Parse(caloriesTextbox.Text));
        ////            rdiLabel.Text = Math.Round(rdiPercentage).ToString() + "% on a RDI of " + inputRdiTextBox.Text + " calories.";

        ////        }
        ////    }
        ////    else if (result == DialogResult.No)
        ////    {
        ////        MessageBox.Show("Go to 'Meal Calculator' tab!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ////    }
        ////}

        //calculates the serving size 
        public decimal CalculateServingSize(decimal initialServing, decimal inputServingSize)
        {
            //dividing the input serving size from serving size of selected food type
            //so it can times every nutrition value in regards to input serving size
            decimal total = inputServingSize / initialServing;

            return total;
        }
        //updates the serving size
        ////private void servingUpdateButton_Click(object sender, EventArgs e)
        ////{
        ////    if (caloriesTextbox.Text == string.Empty)
        ////    {
        ////        MessageBox.Show("Select a Food Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }
        ////    else if (quantityTextbox.Text == string.Empty)
        ////    {
        ////        MessageBox.Show("Field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }
        ////    else if (decimal.Parse(quantityTextbox.Text) > 1000)
        ////    {
        ////        MessageBox.Show("Can't exceed 1000 grams", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }//************not quite working, this only works at inital serving size.***********

        ////    else
        ////    {
        ////        //getting the result of dividing input serving size from serving size of the food type
        ////        decimal answer = CalculateServingSize(decimal.Parse(ServingSize.servingSize.ToString()), decimal.Parse(quantityTextbox.Text));
        ////        //with the answer acquired above, it times calories to get the correct answer relating to the serving size
        ////        decimal newCalories = Math.Round(answer * decimal.Parse(ServingSize.initialCalories.ToString()));
        ////        //using the answer above, calculating the updated nutritions 
        ////        decimal newProtein = answer * decimal.Parse(ServingSize.initialProtein);
        ////        decimal newCarb = answer * decimal.Parse(ServingSize.initialCarb);
        ////        decimal newFat = answer * decimal.Parse(ServingSize.initialFat);

        ////        // updating other areas prior to the new values above.

        ////        if (decimal.Parse(inputRdiTextBox.Text) < newCalories)
        ////        {
        ////            //rdi check is true
        ////            RDICheck(decimal.Parse(inputRdiTextBox.Text), newCalories);
        ////            //calorie surpassed so calculates the amount of the overdose
        ////            decimal surpass = Math.Round(CalorieSurpass(newCalories, decimal.Parse(inputRdiTextBox.Text)));
        ////            rdiLabel.Text = "The amount of calorie intake have surpassed" + Environment.NewLine + " by %" + surpass.ToString();
        ////            //rounding the answer to 2 sf
        ////            caloriesTextbox.Text = Math.Round(double.Parse(newCalories.ToString())).ToString();
        ////            proteinTextbox.Text = Math.Round(double.Parse(newProtein.ToString())).ToString();
        ////            carbTextbox.Text = Math.Round(double.Parse(newCarb.ToString())).ToString();
        ////            fatTextbox.Text = Math.Round(double.Parse(newFat.ToString())).ToString();
        ////            //output
        ////            calorieLabel.Text = "There are " + caloriesTextbox.Text + " Calories in " + quantityTextbox.Text
        ////                + " grams of " + Environment.NewLine + listBox.SelectedItem;

        ////        }
        ////        else
        ////        {
        ////            try
        ////            {
        ////                //rounding the answer to 2 sf
        ////                caloriesTextbox.Text = Math.Round(double.Parse(newCalories.ToString())).ToString();
        ////                proteinTextbox.Text = Math.Round(double.Parse(newProtein.ToString())).ToString();
        ////                carbTextbox.Text = Math.Round(double.Parse(newCarb.ToString())).ToString();
        ////                fatTextbox.Text = Math.Round(double.Parse(newFat.ToString())).ToString();

        ////                quantityTextbox.Text = quantityTextbox.Text;
        ////                //output
        ////                calorieLabel.Text = "There are " + caloriesTextbox.Text + " Calories in " + quantityTextbox.Text
        ////                    + " grams of " + Environment.NewLine + listBox.SelectedItem;
        ////                MessageBox.Show("Updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
        ////                //calculate the percentage based on input rdi 
        ////                decimal rdiPercentage = CalculateRDIPercentage(decimal.Parse(inputRdiTextBox.Text), decimal.Parse(caloriesTextbox.Text));
        ////                rdiLabel.Text = Math.Round(rdiPercentage).ToString() + "% on a RDI of " + inputRdiTextBox.Text + " calories.";

        ////                GenerateRDIChart(int.Parse(inputRdiTextBox.Text), int.Parse(caloriesTextbox.Text));

        ////                //checking if the meals contain the updated meal, if so then updates it to following textboxes
        ////                if (listBox.SelectedItem.ToString().Equals(meal1NameTextbox.Text))
        ////                {
        ////                    meal1CaloriesTextBox.Text = caloriesTextbox.Text;
        ////                    meal1ProteinTextBox.Text = proteinTextbox.Text;
        ////                    meal1CarbTextbox.Text = carbTextbox.Text;
        ////                    meal1FatTextBox.Text = fatTextbox.Text;
        ////                }
        ////                //meal 2
        ////                else if (listBox.SelectedItem.ToString().Equals(meal2NameTextbox.Text))
        ////                {
        ////                    meal2CaloriesTextbox.Text = caloriesTextbox.Text;
        ////                    meal2ProteinTextbox.Text = proteinTextbox.Text;
        ////                    meal2CarbTextbox.Text = carbTextbox.Text;
        ////                    meal2FatTextbox.Text = fatTextbox.Text;

        ////                }//meal 3
        ////                else if (listBox.SelectedItem.ToString().Equals(meal3NameTextbox.Text))
        ////                {
        ////                    meal3CaloriesTextbox.Text = caloriesTextbox.Text;
        ////                    meal3ProteinTextbox.Text = proteinTextbox.Text;
        ////                    meal3CarbTextBox.Text = carbTextbox.Text;
        ////                    meal3FatTextBox.Text = fatTextbox.Text;

        ////                }//side 1
        ////                else if (listBox.SelectedItem.ToString().Equals(sideMeal1NameTextbox.Text))
        ////                {
        ////                    sideMeal1CaloriesTextbox.Text = caloriesTextbox.Text;
        ////                    sideMeal1ProteinTextbox.Text = proteinTextbox.Text;
        ////                    sideMeal1CarbTextbox.Text = carbTextbox.Text;
        ////                    sideMeal1FatTextbox.Text = fatTextbox.Text;

        ////                }//side 2 
        ////                else if (listBox.SelectedItem.ToString().Equals(sideMeal2NameTextbox.Text))
        ////                {
        ////                    sideMeal2CaloriesTextbox.Text = caloriesTextbox.Text;
        ////                    sideMeal2ProteinTextbox.Text = proteinTextbox.Text;
        ////                    sideMeal2CarbTextbox.Text = carbTextbox.Text;
        ////                    sideMeal2FatTextbox.Text = fatTextbox.Text;
        ////                }//side 3
        ////                else if (listBox.SelectedItem.ToString().Equals(sideMeal3NameTextbox.Text))
        ////                {
        ////                    sideMeal3CaloriesTextbox.Text = caloriesTextbox.Text;
        ////                    sideMeal3ProteinTextbox.Text = proteinTextbox.Text;
        ////                    sideMeal3CarbTextbox.Text = carbTextbox.Text;
        ////                    sideMeal3FatTextbox.Text = fatTextbox.Text;
        ////                }
        ////                //sauce 1
        ////                else if (listBox.SelectedItem.ToString().Equals(sauce1NameTextbox.Text))
        ////                {
        ////                    sauce1CalorieTextBox.Text = caloriesTextbox.Text;
        ////                    sauce1ProteinTextBox.Text = proteinTextbox.Text;
        ////                    sauce1CarbTextBox.Text = carbTextbox.Text;
        ////                    sauce1FatTextBox.Text = fatTextbox.Text;
        ////                }
        ////                //sauce 2
        ////                else if (listBox.SelectedItem.ToString().Equals(sauce2NameTextbox.Text))
        ////                {
        ////                    sauce2CalorieTextBox.Text = caloriesTextbox.Text;
        ////                    sauce2ProteinTextBox.Text = proteinTextbox.Text;
        ////                    sauce2CarbTextBox.Text = carbTextbox.Text;
        ////                    sauce2FatTextBox.Text = fatTextbox.Text;
        ////                }
        ////                //sauce 3
        ////                else if (listBox.SelectedItem.ToString().Equals(sauce3NameTextBox.Text))
        ////                {
        ////                    sauce3CalorieTextBox.Text = caloriesTextbox.Text;
        ////                    sauce3ProteinTextBox.Text = proteinTextbox.Text;
        ////                    sauce3CarbTextBox.Text = carbTextbox.Text;
        ////                    sauce3FatTextBox.Text = fatTextbox.Text;
        ////                }
        ////                //sauce 4
        ////                else if (listBox.SelectedItem.ToString().Equals(sauce4NameTextBox.Text))
        ////                {
        ////                    sauce4CalorieTextBox.Text = caloriesTextbox.Text;
        ////                    sauce4ProteinTextBox.Text = proteinTextbox.Text;
        ////                    sauce4CarbTextBox.Text = carbTextbox.Text;
        ////                    sauce4FatTextBox.Text = fatTextbox.Text;
        ////                }
        ////            }
        ////            catch (Exception exc)
        ////            {
        ////                MessageBox.Show("Error Occured: " + exc);
        ////            }
        ////        }
        ////        CalculateTotal();
        ////    }
        ////}

        private void changeServingTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows numbers
            //also disable ShortcutEnabled property
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void inputRdiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows numbers
            //also disable ShortcutEnabled property
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //calculating the meals
        public decimal CalculateMeal(decimal meal1, decimal meal2, decimal meal3, decimal side1, decimal side2, decimal side3, decimal sauce1, decimal sauce2, decimal sauce3, decimal sauce4)
        {
            decimal totalAmountOfNutrition = meal1 + meal2 + meal3 + side1 + side2 + side3 + sauce1 + sauce2 + sauce3 + sauce4;
            return totalAmountOfNutrition;
        }

        //Calculates the total of every nutrition
        ////public void CalculateTotal()
        ////{
        ////    try
        ////    {
        ////        //using calculateMeal method to calculate the total amount of nutritions by clicking confirm meal 
        ////        decimal totalCalories = CalculateMeal(decimal.Parse(meal1CaloriesTextBox.Text), decimal.Parse(meal2CaloriesTextbox.Text),
        ////            decimal.Parse(meal3CaloriesTextbox.Text), decimal.Parse(sideMeal1CaloriesTextbox.Text),
        ////            decimal.Parse(sideMeal2CaloriesTextbox.Text), decimal.Parse(sideMeal3CaloriesTextbox.Text),
        ////            decimal.Parse(sauce1CalorieTextBox.Text), decimal.Parse(sauce2CalorieTextBox.Text), decimal.Parse(sauce3CalorieTextBox.Text),
        ////            decimal.Parse(sauce4CalorieTextBox.Text));
        ////        decimal totalProtein = CalculateMeal(decimal.Parse(meal1ProteinTextBox.Text), decimal.Parse(meal2ProteinTextbox.Text),
        ////            decimal.Parse(meal3ProteinTextbox.Text), decimal.Parse(sideMeal1ProteinTextbox.Text),
        ////            decimal.Parse(sideMeal2ProteinTextbox.Text), decimal.Parse(sideMeal3ProteinTextbox.Text), decimal.Parse(sauce1ProteinTextBox.Text),
        ////            decimal.Parse(sauce2ProteinTextBox.Text), decimal.Parse(sauce3ProteinTextBox.Text),
        ////            decimal.Parse(sauce4ProteinTextBox.Text));
        ////        decimal totalCarb = CalculateMeal(decimal.Parse(meal1CarbTextbox.Text), decimal.Parse(meal2CarbTextbox.Text),
        ////            decimal.Parse(meal3CarbTextBox.Text), decimal.Parse(sideMeal1CarbTextbox.Text), decimal.Parse(sideMeal2CarbTextbox.Text),
        ////            decimal.Parse(sideMeal3CarbTextbox.Text), decimal.Parse(sauce1CarbTextBox.Text), decimal.Parse(sauce2CarbTextBox.Text),
        ////            decimal.Parse(sauce3CarbTextBox.Text), decimal.Parse(sauce4CarbTextBox.Text));
        ////        decimal totalFat = CalculateMeal(decimal.Parse(meal1FatTextBox.Text), decimal.Parse(meal2FatTextbox.Text), decimal.Parse(meal3FatTextBox.Text),
        ////            decimal.Parse(sideMeal1FatTextbox.Text), decimal.Parse(sideMeal2FatTextbox.Text), decimal.Parse(sideMeal3FatTextbox.Text),
        ////            decimal.Parse(sauce1FatTextBox.Text), decimal.Parse(sauce2FatTextBox.Text), decimal.Parse(sauce3FatTextBox.Text),
        ////            decimal.Parse(sauce4FatTextBox.Text)); ;
        ////        //output to related text boxes
        ////        totalCaloriesTextbox.Text = totalCalories.ToString();
        ////        totalProteinTextBox.Text = totalProtein.ToString();
        ////        totalCarbTextBox.Text = totalCarb.ToString();
        ////        totalFatTextBox.Text = totalFat.ToString();
        ////    }
        ////    catch (Exception exc)
        ////    {

        ////        MessageBox.Show("Error Occured: " + exc);
        ////    }
        ////}
        //////Generating Rdi after meal calculation
        ////private void generateTotalChartButton_Click(object sender, EventArgs e)
        ////{
        ////    //if the textbox is empty then output an error message
        ////    if (totalCaloriesTextbox.Text == "")
        ////    {
        ////        MessageBox.Show("You haven't got any meals chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }
        ////    else
        ////    {
        ////        try
        ////        {
        ////            //generating the Calorie breakdown Chart
        ////            CalorieBreakdown(totalFatTextBox.Text, totalCarbTextBox.Text, totalProteinTextBox.Text, totalCaloriesTextbox.Text);
        ////            GenerateCalorieGraph();
        ////            //output for calorie breakdown
        ////            calorieLabel.Text = "There are " + totalCaloriesTextbox.Text + " Calories";
        ////            caloriebreakdownLabel.Text = caloriebreakdownLabel.Text = "Calorie breakdown: " + comboBox.SelectedItem.ToString() + Environment.NewLine
        ////                 + doubleTotalProteinPercentage + "% Protein"
        ////                    + Environment.NewLine + doubleTotalCarbPercentage
        ////                    + "% Carbohydrate" + Environment.NewLine + doubleTotalFatPercentage + "% Fat";

        ////        }
        ////        catch (Exception)
        ////        {
        ////            throw new Exception();
        ////        }
        ////    }

        ////    //if rdi is smaller than calories then output a message
        ////    if (decimal.Parse(inputRdiMealCalculatorTextBox.Text) < decimal.Parse(totalCaloriesTextbox.Text))
        ////    {
        ////        //rdi check is true
        ////        RDICheck(decimal.Parse(inputRdiMealCalculatorTextBox.Text), decimal.Parse(totalCaloriesTextbox.Text));
        ////        //calorie surpassed so calculates the amount of the overdose
        ////        decimal surpass = Math.Round(CalorieSurpass(decimal.Parse(totalCaloriesTextbox.Text), decimal.Parse(inputRdiMealCalculatorTextBox.Text)));
        ////        rdiLabel.Text = "The amount of calorie intake have surpassed" + Environment.NewLine + " by %" + surpass.ToString();
        ////    }

        ////    else
        ////    {
        ////        try
        ////        {
        ////            //generating the RDI chart
        ////            GenerateRDIChart(int.Parse(inputRdiMealCalculatorTextBox.Text), int.Parse(totalCaloriesTextbox.Text));
        ////            //if the rdi textbox is not empty then calculate it by the input.
        ////            decimal rdiPercentage = CalculateRDIPercentage(decimal.Parse(inputRdiMealCalculatorTextBox.Text), decimal.Parse(totalCaloriesTextbox.Text));
        ////            rdiLabel.Text = Math.Round(rdiPercentage).ToString() + "% on a RDI of " + inputRdiMealCalculatorTextBox.Text + " calories.";

        ////        }
        ////        catch (Exception)
        ////        {

        ////            MessageBox.Show("Error: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////        }
        ////        MessageBox.Show("Charts are created! Please check the 'Charts' Tab!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        ////    }
        ////}

        //Calculates the percentage of nutritions based on the input and the class Calorie_Breakdown 
        public CalorieBreakDownResults CalorieBreakdown(string fat, string carb, string protein, string calories)
        {
            decimal fatCalories = Calorie_Breakdown.fatToCalories(decimal.Parse(fat));
            decimal totalFatPercentage = Calorie_Breakdown.caloriesInFat(fatCalories, decimal.Parse(calories));
            var roundedTotalFatPercentage = double.Parse(Math.Round(totalFatPercentage).ToString());

            decimal carbCalories = Calorie_Breakdown.carbToCalories(decimal.Parse(carb));
            decimal totalCarbPercentage = Calorie_Breakdown.caloriesInCarb(carbCalories, decimal.Parse(calories));
            var roundedTotalCarbPercentage = double.Parse(Math.Round(totalCarbPercentage).ToString());

            decimal proteinCalories = Calorie_Breakdown.proteinToCalories(decimal.Parse(protein));
            decimal totalProteinPercentage = Calorie_Breakdown.caloriesinProtein(proteinCalories, decimal.Parse(calories));
            var roundedTotalProteinPercentage = double.Parse(Math.Round(totalProteinPercentage).ToString());

            var calorieBreakdownResults = new CalorieBreakDownResults()
            {
                TotalCarbPercentage = roundedTotalCarbPercentage,
                TotalFatPercentage = roundedTotalFatPercentage,
                TotalProteinPercentage = roundedTotalProteinPercentage
            };

            return calorieBreakdownResults;
        }
        //calculates the percentage of surpass off the rdi from calorie intake
        public decimal CalorieSurpass(decimal calorie, decimal rdi)
        {
            decimal total = ((calorie / rdi) * 100) - 100;
            return total;
        }
        //press enter to search on inputtextbox
        private void inputTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(this, new EventArgs());
            }
        }

        private void quantityTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows numbers
            //also disable ShortcutEnabled property
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //disposal
        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset EVERYTHING?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    inputTextbox.Text = "";
                    listBox.SelectedItem = null;

                    //setting nutrition summary textbox to 0
                    quantityTextbox.Text = "0";
                    caloriesTextbox.Text = "0";
                    proteinTextbox.Text = "0";
                    carbTextbox.Text = "0";
                    fatTextbox.Text = "0";

                    //calorie breakdown and rdi labels
                    caloriebreakdownLabel.Text = "";
                    calorieLabel.Text = "";
                    //charts reset
                    calorieChart.Series[0].Points.Clear();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error Occurred: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bMRCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMRForm bmr = new BMRForm();
            bmr.ShowDialog();
        }

        private void showMealsButton_Click(object sender, EventArgs e)
        {
            this.mealsForm.Show();
        }

        private void addMealButton_Click(object sender, EventArgs e)
        {
            var addMeal = new AddToMealsForm();

            addMeal.mealsForm = this.mealsForm;
            addMeal.meals = new MealNutrition(this.selectedMealName, quantityTextbox.Text, caloriesTextbox.Text,
                    proteinTextbox.Text, carbTextbox.Text, fatTextbox.Text);

            addMeal.ShowDialog();
        }
    }
}



