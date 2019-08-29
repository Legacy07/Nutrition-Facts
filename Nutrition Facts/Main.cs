using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Deployment.Application;

namespace Nutrition_Facts
{
    public partial class Main : Form
    {

        private DataTable dataTable;
        private UpdateCheckInfo info;
        private double doubleTotalFatPercentage;
        private double doubleTotalCarbPercentage;
        private double doubleTotalProteinPercentage;

        public bool rdiReturn = false;

        public Main()
        {
            InitializeComponent();
            this.FillListbox();

            this.ToolTips();

            this.SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            //setting meal calculator textbox to 0 
            meal1CaloriesTextBox.Text = "0";
            meal1ProteinTextBox.Text = "0";
            meal1CarbTextbox.Text = "0";
            meal1FatTextBox.Text = "0";
            meal2CaloriesTextbox.Text = "0";
            meal2ProteinTextbox.Text = "0";
            meal2CarbTextbox.Text = "0";
            meal2FatTextbox.Text = "0";
            meal3CaloriesTextbox.Text = "0";
            meal3ProteinTextbox.Text = "0";
            meal3CarbTextBox.Text = "0";
            meal3FatTextBox.Text = "0";
            sideMeal1CaloriesTextbox.Text = "0";
            sideMeal1ProteinTextbox.Text = "0";
            sideMeal1CarbTextbox.Text = "0";
            sideMeal1FatTextbox.Text = "0";
            sideMeal2CaloriesTextbox.Text = "0";
            sideMeal2ProteinTextbox.Text = "0";
            sideMeal2CarbTextbox.Text = "0";
            sideMeal2FatTextbox.Text = "0";
            sideMeal3CaloriesTextbox.Text = "0";
            sideMeal3ProteinTextbox.Text = "0";
            sideMeal3CarbTextbox.Text = "0";
            sideMeal3FatTextbox.Text = "0";
            sauce1CalorieTextBox.Text = "0";
            sauce1CarbTextBox.Text = "0";
            sauce1ProteinTextBox.Text = "0";
            sauce1FatTextBox.Text = "0";
            sauce2CalorieTextBox.Text = "0";
            sauce2CarbTextBox.Text = "0";
            sauce2ProteinTextBox.Text = "0";
            sauce2FatTextBox.Text = "0";
            sauce3CalorieTextBox.Text = "0";
            sauce3CarbTextBox.Text = "0";
            sauce3ProteinTextBox.Text = "0";
            sauce3FatTextBox.Text = "0";
            sauce4CalorieTextBox.Text = "0";
            sauce4CarbTextBox.Text = "0";
            sauce4ProteinTextBox.Text = "0";
            sauce4FatTextBox.Text = "0";

            //setting nutrition summary textbox to 0
            quantityTextbox.Text = "0";
            caloriesTextbox.Text = "0";
            proteinTextbox.Text = "0";
            carbTextbox.Text = "0";
            fatTextbox.Text = "0";

            //setting total nutrition summary textbox to 0
            totalCaloriesTextbox.Text = "0";
            totalProteinTextBox.Text = "0";
            totalCarbTextBox.Text = "0";
            totalFatTextBox.Text = "0";

            inputRdiTextBox.Text = "2000";
            inputRdiMealCalculatorTextBox.Text = "2000";
        }

        private void ToolTips()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(calorieChart, "Calorie breakdown to illustrate nutritions taken");
            tooltip.SetToolTip(rdiChart, "Amount of calories in relation to set RDI");
            tooltip.SetToolTip(inputRDIMealCalculatorLabel, "* Average RDI is 2000 Calories");
            tooltip.SetToolTip(inputRDILabel, "* Average RDI is 2000 Calories");
            tooltip.SetToolTip(servingSizeLabel, "* In grams");
            tooltip.SetToolTip(servingUpdateButton, "Update Serving Size");
            tooltip.SetToolTip(resetButton, "Resets Everything");
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

            /*  else if (!listBox.Items[listBox.Items.Count - 1].ToString().ToLower().Contains(input.ToLower()))
              {
                  MessageBox.Show("Enter a valid food type");

              }*/
            else
            {
                //searching through listbox 
                //can search for items other than the first item in list box, gives a null reference
                for (int i = listBox.Items.Count - 1; i >= 0; i--)
                {
                    if (listBox.Items[i].ToString().ToLower().Contains(input.ToLower()))
                    {
                        listBox.SetSelected(i, true);
                    }

                }
            }
        }

        public void FillListbox()
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

            foreach (DataRow dr in dataTable.Rows)
            {
                listBox.Items.Add(dr["Name"].ToString());
            }

            connection.Close();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //connection
            SqlConnection connection = DatabaseClass.GetConnection();

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            if (listBox.SelectedIndex == -1)
            {
            }
            else
            {
                string query = "Select * from Facts Where Name ='" + listBox.SelectedItem.ToString() + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    quantityTextbox.Text = row["Quantity"].ToString();
                    caloriesTextbox.Text = row["Calorie"].ToString();
                    proteinTextbox.Text = row["Protein"].ToString();
                    carbTextbox.Text = row["Carb"].ToString();
                    fatTextbox.Text = row["Fat"].ToString();
                }
                ServingSize.servingSize = quantityTextbox.Text;
                string caloriesTemp = caloriesTextbox.Text;
                string proteinTemp = proteinTextbox.Text;
                string carbTemp = carbTextbox.Text;
                string fatTemp = fatTextbox.Text;
                ServingSize.initialCalories = caloriesTemp;
                ServingSize.initialProtein = proteinTemp;
                ServingSize.initialCarb = carbTemp;
                ServingSize.initialFat = fatTemp;

                calorieLabel.Text = "There are " + caloriesTextbox.Text + " Calories in " + quantityTextbox.Text + " grams of " + Environment.NewLine + listBox.SelectedItem;

                this.CalorieBreakdown(fatTextbox.Text, carbTextbox.Text, proteinTextbox.Text, caloriesTextbox.Text);

                caloriebreakdownLabel.Text = "Calorie breakdown:" + Environment.NewLine + doubleTotalProteinPercentage + "% Protein"
                    + Environment.NewLine + doubleTotalCarbPercentage
                    + "% Carbohydrate" + Environment.NewLine + doubleTotalFatPercentage + "% Fat";

                this.GenerateCalorieGraph();

                if (inputRdiTextBox.Text == "")
                {
                    decimal averageRDIPercentage = this.PercentageOfAverageRDI(decimal.Parse(caloriesTextbox.Text));

                    rdiLabel.Text = Math.Round(averageRDIPercentage).ToString() + "% on an average RDI of 2000 calories.";
                }
                //if the rdi textbox is not empty then calculate it by the input.
                else
                {
                    decimal rdiPercentage = CalculateRDIPercentage(decimal.Parse(inputRdiTextBox.Text), decimal.Parse(caloriesTextbox.Text));
                    rdiLabel.Text = Math.Round(rdiPercentage).ToString() + "% on a RDI of " + inputRdiTextBox.Text + " calories.";
                }
                this.GenerateRDIChart(int.Parse(inputRdiTextBox.Text), int.Parse(caloriesTextbox.Text));
            }
            connection.Close();
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
                    calorieChart.Series["Series"].Points.AddXY("Fat", doubleTotalFatPercentage);
                    calorieChart.Series["Series"].Points.AddXY("Protein", doubleTotalProteinPercentage);
                    calorieChart.Series["Series"].Points.AddXY("Carbohydrate", doubleTotalCarbPercentage);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error occured! " + exc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void GenerateRDIChart(int rdi, int calories)
        {
            //if the input of RDI is bigger than calories then output the chart based on the input
            if (decimal.Parse(rdi.ToString()) > decimal.Parse(calories.ToString()))
            {
                int finalRDI = int.Parse(rdi.ToString()) - int.Parse(calories.ToString());

                rdiChart.Series[0].Points.Clear();

                try
                {
                    rdiChart.Series["Series"].Points.AddXY("RDI", finalRDI.ToString());
                    rdiChart.Series["Series"].Points.AddXY("Calories", calories.ToString());
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error occured! " + exc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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

        public bool RDICheck(decimal rdi, decimal calories)
        {
            //checking to see if the set rdi is smaller than the amout of calories
            if (rdi < calories)
            {
                MessageBox.Show("The amount of calories surpassed your RDI, cannot output a chart!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rdiReturn = true;
            }
            return true;
        }
        //calculating the rdi and outputs a chart
        private void calculateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you calculating off the selected food type? If you trying to calculate from the meal calculator then select 'NO'!"
                , "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if rdi is smaller than calories then output a message
            if (decimal.Parse(inputRdiTextBox.Text) < decimal.Parse(caloriesTextbox.Text))
            {
                //rdi check is true
                RDICheck(decimal.Parse(inputRdiTextBox.Text), decimal.Parse(caloriesTextbox.Text));
                //calorie surpassed so calculates the amount of the overdose
                decimal surpass = Math.Round(CalorieSurpass(decimal.Parse(caloriesTextbox.Text), decimal.Parse(inputRdiTextBox.Text)));
                rdiLabel.Text = "The amount of calorie intake have surpassed" + Environment.NewLine + " by %" + surpass.ToString();

            }
            //if selected yes then carry on 
            else if (result == DialogResult.Yes)
            {
                //if the textbox is empty then output an error message
                if (caloriesTextbox.Text == "" || inputRdiTextBox.Text == "")
                {
                    MessageBox.Show("You haven't selected a food type or the input of your RDI is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                //generate the chart
                {

                    calorieLabel.Text = "There are " + caloriesTextbox.Text + " Calories in " + quantityTextbox.Text + " grams of " + Environment.NewLine + listBox.SelectedItem;
                    //using this method will tell us the the percentages of the calorie breakdown
                    CalorieBreakdown(fatTextbox.Text, carbTextbox.Text, proteinTextbox.Text, caloriesTextbox.Text);
                    //output
                    caloriebreakdownLabel.Text = "Calorie breakdown:" + Environment.NewLine + doubleTotalProteinPercentage + "% Protein"
                        + Environment.NewLine + doubleTotalCarbPercentage
                        + "% Carbohydrate" + Environment.NewLine + doubleTotalFatPercentage + "% Fat";
                    //generating calorie breakdown chart
                    GenerateCalorieGraph();
                    //rdi chart
                    GenerateRDIChart(int.Parse(inputRdiTextBox.Text), int.Parse(caloriesTextbox.Text));
                    decimal rdiPercentage = CalculateRDIPercentage(decimal.Parse(inputRdiTextBox.Text), decimal.Parse(caloriesTextbox.Text));
                    rdiLabel.Text = Math.Round(rdiPercentage).ToString() + "% on a RDI of " + inputRdiTextBox.Text + " calories.";

                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Go to 'Meal Calculator' tab!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //calculates the serving size 
        public decimal CalculateServingSize(decimal initialServing, decimal inputServingSize)
        {
            //dividing the input serving size from serving size of selected food type
            //so it can times every nutrition value in regards to input serving size
            decimal total = inputServingSize / initialServing;

            return total;

        }
        //updates the serving size
        private void servingUpdateButton_Click(object sender, EventArgs e)
        {
            if (caloriesTextbox.Text == "")
            {
                MessageBox.Show("Select a Food Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quantityTextbox.Text == "")
            {
                MessageBox.Show("Field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (decimal.Parse(quantityTextbox.Text) > 1000)
            {
                MessageBox.Show("Can't exceed 1000 grams", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//************not quite working, this only works at inital serving size.***********

            else

            {
                //First off im cheking if the updated calories is not surpassing the input rdi, if it is then outputs an error message
                //getting the result of dividing input serving size from serving size of the food type
                decimal answer = CalculateServingSize(decimal.Parse(ServingSize.servingSize.ToString()), decimal.Parse(quantityTextbox.Text));
                //with the answer acquired above, it times calories to get the correct answer relating to the serving size
                decimal newCalories = Math.Round(answer * decimal.Parse(ServingSize.initialCalories.ToString()));
                //using the answer above, calculating the updated nutritions 
                decimal newProtein = answer * decimal.Parse(ServingSize.initialProtein);
                decimal newCarb = answer * decimal.Parse(ServingSize.initialCarb);
                decimal newFat = answer * decimal.Parse(ServingSize.initialFat);
                //if rdi is smaller than calories then output a message
                if (decimal.Parse(inputRdiTextBox.Text) < newCalories)
                {
                    //rdi check is true
                    RDICheck(decimal.Parse(inputRdiTextBox.Text), newCalories);
                    //calorie surpassed so calculates the amount of the overdose
                    decimal surpass = Math.Round(CalorieSurpass(newCalories, decimal.Parse(inputRdiTextBox.Text)));
                    rdiLabel.Text = "The amount of calorie intake have surpassed" + Environment.NewLine + " by %" + surpass.ToString();
                    //rounding the answer to 2 sf
                    caloriesTextbox.Text = Math.Round(double.Parse(newCalories.ToString())).ToString();
                    proteinTextbox.Text = Math.Round(double.Parse(newProtein.ToString())).ToString();
                    carbTextbox.Text = Math.Round(double.Parse(newCarb.ToString())).ToString();
                    fatTextbox.Text = Math.Round(double.Parse(newFat.ToString())).ToString();
                    //output
                    calorieLabel.Text = "There are " + caloriesTextbox.Text + " Calories in " + quantityTextbox.Text
                        + " grams of " + Environment.NewLine + listBox.SelectedItem;

                }
                else
                {
                    try
                    {
                        //rounding the answer to 2 sf
                        caloriesTextbox.Text = Math.Round(double.Parse(newCalories.ToString())).ToString();
                        proteinTextbox.Text = Math.Round(double.Parse(newProtein.ToString())).ToString();
                        carbTextbox.Text = Math.Round(double.Parse(newCarb.ToString())).ToString();
                        fatTextbox.Text = Math.Round(double.Parse(newFat.ToString())).ToString();

                        quantityTextbox.Text = quantityTextbox.Text;
                        //output
                        calorieLabel.Text = "There are " + caloriesTextbox.Text + " Calories in " + quantityTextbox.Text
                            + " grams of " + Environment.NewLine + listBox.SelectedItem;
                        MessageBox.Show("Updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                        //calculate the percentage based on input rdi 
                        decimal rdiPercentage = CalculateRDIPercentage(decimal.Parse(inputRdiTextBox.Text), decimal.Parse(caloriesTextbox.Text));
                        rdiLabel.Text = Math.Round(rdiPercentage).ToString() + "% on a RDI of " + inputRdiTextBox.Text + " calories.";

                        GenerateRDIChart(int.Parse(inputRdiTextBox.Text), int.Parse(caloriesTextbox.Text));

                        //checking if the meals contain the updated meal, if so then updates it to following textboxes
                        if (listBox.SelectedItem.ToString().Equals(meal1NameTextbox.Text))
                        {
                            meal1CaloriesTextBox.Text = caloriesTextbox.Text;
                            meal1ProteinTextBox.Text = proteinTextbox.Text;
                            meal1CarbTextbox.Text = carbTextbox.Text;
                            meal1FatTextBox.Text = fatTextbox.Text;

                        }
                        //meal 2
                        else if (listBox.SelectedItem.ToString().Equals(meal2NameTextbox.Text))
                        {
                            meal2CaloriesTextbox.Text = caloriesTextbox.Text;
                            meal2ProteinTextbox.Text = proteinTextbox.Text;
                            meal2CarbTextbox.Text = carbTextbox.Text;
                            meal2FatTextbox.Text = fatTextbox.Text;

                        }//meal 3
                        else if (listBox.SelectedItem.ToString().Equals(meal3NameTextbox.Text))
                        {
                            meal3CaloriesTextbox.Text = caloriesTextbox.Text;
                            meal3ProteinTextbox.Text = proteinTextbox.Text;
                            meal3CarbTextBox.Text = carbTextbox.Text;
                            meal3FatTextBox.Text = fatTextbox.Text;

                        }//side 1
                        else if (listBox.SelectedItem.ToString().Equals(sideMeal1NameTextbox.Text))
                        {
                            sideMeal1CaloriesTextbox.Text = caloriesTextbox.Text;
                            sideMeal1ProteinTextbox.Text = proteinTextbox.Text;
                            sideMeal1CarbTextbox.Text = carbTextbox.Text;
                            sideMeal1FatTextbox.Text = fatTextbox.Text;

                        }//side 2 
                        else if (listBox.SelectedItem.ToString().Equals(sideMeal2NameTextbox.Text))
                        {
                            sideMeal2CaloriesTextbox.Text = caloriesTextbox.Text;
                            sideMeal2ProteinTextbox.Text = proteinTextbox.Text;
                            sideMeal2CarbTextbox.Text = carbTextbox.Text;
                            sideMeal2FatTextbox.Text = fatTextbox.Text;
                        }//side 3
                        else if (listBox.SelectedItem.ToString().Equals(sideMeal3NameTextbox.Text))
                        {
                            sideMeal3CaloriesTextbox.Text = caloriesTextbox.Text;
                            sideMeal3ProteinTextbox.Text = proteinTextbox.Text;
                            sideMeal3CarbTextbox.Text = carbTextbox.Text;
                            sideMeal3FatTextbox.Text = fatTextbox.Text;
                        }
                        //sauce 1
                        else if (listBox.SelectedItem.ToString().Equals(sauce1NameTextbox.Text))
                        {
                            sauce1CalorieTextBox.Text = caloriesTextbox.Text;
                            sauce1ProteinTextBox.Text = proteinTextbox.Text;
                            sauce1CarbTextBox.Text = carbTextbox.Text;
                            sauce1FatTextBox.Text = fatTextbox.Text;
                        }
                        //sauce 2
                        else if (listBox.SelectedItem.ToString().Equals(sauce2NameTextbox.Text))
                        {
                            sauce2CalorieTextBox.Text = caloriesTextbox.Text;
                            sauce2ProteinTextBox.Text = proteinTextbox.Text;
                            sauce2CarbTextBox.Text = carbTextbox.Text;
                            sauce2FatTextBox.Text = fatTextbox.Text;
                        }
                        //sauce 3
                        else if (listBox.SelectedItem.ToString().Equals(sauce3NameTextBox.Text))
                        {
                            sauce3CalorieTextBox.Text = caloriesTextbox.Text;
                            sauce3ProteinTextBox.Text = proteinTextbox.Text;
                            sauce3CarbTextBox.Text = carbTextbox.Text;
                            sauce3FatTextBox.Text = fatTextbox.Text;
                        }
                        //sauce 4
                        else if (listBox.SelectedItem.ToString().Equals(sauce4NameTextBox.Text))
                        {
                            sauce4CalorieTextBox.Text = caloriesTextbox.Text;
                            sauce4ProteinTextBox.Text = proteinTextbox.Text;
                            sauce4CarbTextBox.Text = carbTextbox.Text;
                            sauce4FatTextBox.Text = fatTextbox.Text;
                        }


                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show("Error Occured: " + exc);
                    }
                }
                CalculateTotal();
            }
        }

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

        //can create a tick box button to save meal times under total, and a output meals button to output the saved meals when clicked 
        //Confirming Meal 1
        private void meal1Button_Click(object sender, EventArgs e)
        {
            //whatever is in the nutrition summary text boxes it copies to meal textboxes
            meal1NameTextbox.Text = listBox.GetItemText(listBox.SelectedItem);
            meal1CaloriesTextBox.Text = caloriesTextbox.Text;
            meal1ProteinTextBox.Text = proteinTextbox.Text;
            meal1FatTextBox.Text = fatTextbox.Text;
            meal1CarbTextbox.Text = carbTextbox.Text;

            if (comboBox.Text == "")
            {
                MessageBox.Show("Please choose your Meal Time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Meal!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBox.Text == "Breakfast")
            {
                //saving textbox values in a static class
                BreakfastMeal1.name = meal1NameTextbox.Text;
                BreakfastMeal1.calories = meal1CaloriesTextBox.Text;
                BreakfastMeal1.protein = meal1ProteinTextBox.Text;
                BreakfastMeal1.fat = meal1FatTextBox.Text;
                BreakfastMeal1.carb = meal1CarbTextbox.Text;

                TotalBreakfast.calories = totalCaloriesTextbox.Text;
                TotalBreakfast.protein = totalProteinTextBox.Text;
                TotalBreakfast.carb = totalCarbTextBox.Text;
                TotalBreakfast.fat = totalFatTextBox.Text;

            }
            else if (comboBox.Text == "Lunch")
            {
                LunchMeal1.name = meal1NameTextbox.Text;
                LunchMeal1.calories = meal1CaloriesTextBox.Text;
                LunchMeal1.protein = meal1ProteinTextBox.Text;
                LunchMeal1.fat = meal1FatTextBox.Text;
                LunchMeal1.carb = meal1CarbTextbox.Text;

                TotalLunch.calories = totalCaloriesTextbox.Text;
                TotalLunch.protein = totalProteinTextBox.Text;
                TotalLunch.carb = totalCarbTextBox.Text;
                TotalLunch.fat = totalFatTextBox.Text;
            }
            else if (comboBox.Text == "Dinner")
            {
                DinnerMeal1.name = meal1NameTextbox.Text;
                DinnerMeal1.calories = meal1CaloriesTextBox.Text;
                DinnerMeal1.protein = meal1ProteinTextBox.Text;
                DinnerMeal1.fat = meal1FatTextBox.Text;
                DinnerMeal1.carb = meal1CarbTextbox.Text;

                TotalDinner.calories = totalCaloriesTextbox.Text;
                TotalDinner.protein = totalProteinTextBox.Text;
                TotalDinner.carb = totalCarbTextBox.Text;
                TotalDinner.fat = totalFatTextBox.Text;
            }
            CalculateTotal();
        }
        //Confriming Meal 2
        private void meal2Button_Click(object sender, EventArgs e)
        {
            //whatever is in the nutrition summary text boxes it copies to meal textboxes
            meal2NameTextbox.Text = listBox.GetItemText(listBox.SelectedItem);
            meal2CaloriesTextbox.Text = caloriesTextbox.Text;
            meal2ProteinTextbox.Text = proteinTextbox.Text;
            meal2FatTextbox.Text = fatTextbox.Text;
            meal2CarbTextbox.Text = carbTextbox.Text;

            if (comboBox.Text == "")
            {
                MessageBox.Show("Please choose your Meal Time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Meal!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBox.Text == "Breakfast")
            {
                BreakfastMeal2.name = meal2NameTextbox.Text;
                BreakfastMeal2.calories = meal2CaloriesTextbox.Text;
                BreakfastMeal2.protein = meal2ProteinTextbox.Text;
                BreakfastMeal2.carb = meal2CarbTextbox.Text;
                BreakfastMeal2.fat = meal2FatTextbox.Text;

                TotalBreakfast.calories = totalCaloriesTextbox.Text;
                TotalBreakfast.protein = totalProteinTextBox.Text;
                TotalBreakfast.carb = totalCarbTextBox.Text;
                TotalBreakfast.fat = totalFatTextBox.Text;

            }
            else if (comboBox.Text == "Lunch")
            {

                LunchMeal2.name = meal2NameTextbox.Text;
                LunchMeal2.calories = meal2CaloriesTextbox.Text;
                LunchMeal2.protein = meal2ProteinTextbox.Text;
                LunchMeal2.carb = meal2CarbTextbox.Text;
                LunchMeal2.fat = meal2FatTextbox.Text;

                TotalLunch.calories = totalCaloriesTextbox.Text;
                TotalLunch.protein = totalProteinTextBox.Text;
                TotalLunch.carb = totalCarbTextBox.Text;
                TotalLunch.fat = totalFatTextBox.Text;
            }
            else if (comboBox.Text == "Dinner")
            {
                DinnerMeal2.name = meal2NameTextbox.Text;
                DinnerMeal2.calories = meal2CaloriesTextbox.Text;
                DinnerMeal2.protein = meal2ProteinTextbox.Text;
                DinnerMeal2.carb = meal2CarbTextbox.Text;
                DinnerMeal2.fat = meal2FatTextbox.Text;

                TotalDinner.calories = totalCaloriesTextbox.Text;
                TotalDinner.protein = totalProteinTextBox.Text;
                TotalDinner.carb = totalCarbTextBox.Text;
                TotalDinner.fat = totalFatTextBox.Text;
            }


            CalculateTotal();
        }
        //Confirming Meal 3
        private void meal3Button_Click(object sender, EventArgs e)
        {
            //whatever is in the nutrition summary text boxes it copies to meal textboxes
            meal3NameTextbox.Text = listBox.GetItemText(listBox.SelectedItem);
            meal3CaloriesTextbox.Text = caloriesTextbox.Text;
            meal3ProteinTextbox.Text = proteinTextbox.Text;
            meal3FatTextBox.Text = fatTextbox.Text;
            meal3CarbTextBox.Text = carbTextbox.Text;

            if (comboBox.Text == "")
            {
                MessageBox.Show("Please choose your Meal Time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Meal!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBox.Text == "Breakfast")
            {
                BreakfastMeal3.name = meal3NameTextbox.Text;
                BreakfastMeal3.calories = meal3CaloriesTextbox.Text;
                BreakfastMeal3.protein = meal3ProteinTextbox.Text;
                BreakfastMeal3.carb = meal3CarbTextBox.Text;
                BreakfastMeal3.fat = meal3FatTextBox.Text;

                TotalBreakfast.calories = totalCaloriesTextbox.Text;
                TotalBreakfast.protein = totalProteinTextBox.Text;
                TotalBreakfast.carb = totalCarbTextBox.Text;
                TotalBreakfast.fat = totalFatTextBox.Text;

            }
            else if (comboBox.Text == "Lunch")
            {
                LunchMeal3.name = meal3NameTextbox.Text;
                LunchMeal3.calories = meal3CaloriesTextbox.Text;
                LunchMeal3.protein = meal3ProteinTextbox.Text;
                LunchMeal3.carb = meal3CarbTextBox.Text;
                LunchMeal3.fat = meal3FatTextBox.Text;

                TotalLunch.calories = totalCaloriesTextbox.Text;
                TotalLunch.protein = totalProteinTextBox.Text;
                TotalLunch.carb = totalCarbTextBox.Text;
                TotalLunch.fat = totalFatTextBox.Text;
            }
            else if (comboBox.Text == "Dinner")
            {
                DinnerMeal3.name = meal3NameTextbox.Text;
                DinnerMeal3.calories = meal3CaloriesTextbox.Text;
                DinnerMeal3.protein = meal3ProteinTextbox.Text;
                DinnerMeal3.carb = meal3CarbTextBox.Text;
                DinnerMeal3.fat = meal3FatTextBox.Text;

                TotalDinner.calories = totalCaloriesTextbox.Text;
                TotalDinner.protein = totalProteinTextBox.Text;
                TotalDinner.carb = totalCarbTextBox.Text;
                TotalDinner.fat = totalFatTextBox.Text;
            }

            CalculateTotal();
        }

        //calculating the meals
        public decimal CalculateMeal(decimal meal1, decimal meal2, decimal meal3, decimal side1, decimal side2, decimal side3, decimal sauce1, decimal sauce2, decimal sauce3, decimal sauce4)
        {
            decimal totalAmountOfNutrition = meal1 + meal2 + meal3 + side1 + side2 + side3 + sauce1 + sauce2 + sauce3 + sauce4;
            return totalAmountOfNutrition;
        }

        //when combobox value is changed, output the saved static data 
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            confirmMeal1Button.Enabled = true;
            confirmMeal2Button.Enabled = true;
            confirmMeal3Button.Enabled = true;
            confirmSide1Button.Enabled = true;
            confirmSide2Button.Enabled = true;
            confirmSide3Button.Enabled = true;
            confirmSauce1Button.Enabled = true;
            confirmSauce2Button.Enabled = true;
            confirmSauce3Button.Enabled = true;
            confirmSauce4Button.Enabled = true;

            if (BreakfastMeal1.name == null)
            {
                MessageBox.Show("No meals chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox.Text == "Breakfast")
            {
                meal1NameTextbox.Text = BreakfastMeal1.name;
                meal1CaloriesTextBox.Text = BreakfastMeal1.calories;
                meal1ProteinTextBox.Text = BreakfastMeal1.protein;
                meal1FatTextBox.Text = BreakfastMeal1.fat;
                meal1CarbTextbox.Text = BreakfastMeal1.carb;

                meal2NameTextbox.Text = BreakfastMeal2.name;
                meal2CaloriesTextbox.Text = BreakfastMeal2.calories;
                meal2ProteinTextbox.Text = BreakfastMeal2.protein;
                meal2FatTextbox.Text = BreakfastMeal2.fat;
                meal2CarbTextbox.Text = BreakfastMeal2.carb;

                meal3NameTextbox.Text = BreakfastMeal3.name;
                meal3CaloriesTextbox.Text = BreakfastMeal3.calories;
                meal3ProteinTextbox.Text = BreakfastMeal3.protein;
                meal3FatTextBox.Text = BreakfastMeal3.fat;
                meal3CarbTextBox.Text = BreakfastMeal3.carb;

                sideMeal1NameTextbox.Text = SideMeal1Breakfast.name;
                sideMeal1CaloriesTextbox.Text = SideMeal1Breakfast.calories;
                sideMeal1CarbTextbox.Text = SideMeal1Breakfast.carb;
                sideMeal1ProteinTextbox.Text = SideMeal1Breakfast.protein;
                sideMeal1FatTextbox.Text = SideMeal1Breakfast.fat;

                sideMeal2NameTextbox.Text = SideMeal2Breakfast.name;
                sideMeal2CaloriesTextbox.Text = SideMeal2Breakfast.calories;
                sideMeal2CarbTextbox.Text = SideMeal2Breakfast.carb;
                sideMeal2ProteinTextbox.Text = SideMeal2Breakfast.protein;
                sideMeal2FatTextbox.Text = SideMeal2Breakfast.fat;

                sideMeal3NameTextbox.Text = SideMeal3Breakfast.name;
                sideMeal3CaloriesTextbox.Text = SideMeal3Breakfast.calories;
                sideMeal3CarbTextbox.Text = SideMeal3Breakfast.carb;
                sideMeal3ProteinTextbox.Text = SideMeal3Breakfast.protein;
                sideMeal3FatTextbox.Text = SideMeal3Breakfast.fat;

                sauce1NameTextbox.Text = Sauce1Breakfast.name;
                sauce1CalorieTextBox.Text = Sauce1Breakfast.calories;
                sauce1ProteinTextBox.Text = Sauce1Breakfast.protein;
                sauce1CarbTextBox.Text = Sauce1Breakfast.carb;
                sauce1FatTextBox.Text = Sauce1Breakfast.fat;

                sauce2NameTextbox.Text = Sauce2Breakfast.name;
                sauce2CalorieTextBox.Text = Sauce2Breakfast.calories;
                sauce2ProteinTextBox.Text = Sauce2Breakfast.protein;
                sauce2CarbTextBox.Text = Sauce2Breakfast.carb;
                sauce2FatTextBox.Text = Sauce2Breakfast.fat;

                sauce3NameTextBox.Text = Sauce3Breakfast.name;
                sauce3CalorieTextBox.Text = Sauce3Breakfast.calories;
                sauce3ProteinTextBox.Text = Sauce3Breakfast.protein;
                sauce3CarbTextBox.Text = Sauce3Breakfast.carb;
                sauce3FatTextBox.Text = Sauce3Breakfast.fat;

                sauce4NameTextBox.Text = Sauce4Breakfast.name;
                sauce4CalorieTextBox.Text = Sauce4Breakfast.calories;
                sauce4ProteinTextBox.Text = Sauce4Breakfast.protein;
                sauce4CarbTextBox.Text = Sauce4Breakfast.carb;
                sauce4FatTextBox.Text = Sauce4Breakfast.fat;

                totalCaloriesTextbox.Text = TotalBreakfast.calories;
                totalProteinTextBox.Text = TotalBreakfast.protein;
                totalCarbTextBox.Text = TotalBreakfast.carb;
                totalFatTextBox.Text = TotalBreakfast.fat;

            }
            else if (comboBox.Text == "Lunch")
            {
                meal1NameTextbox.Text = LunchMeal1.name;
                meal1CaloriesTextBox.Text = LunchMeal1.calories;
                meal1ProteinTextBox.Text = LunchMeal1.protein;
                meal1FatTextBox.Text = LunchMeal1.fat;
                meal1CarbTextbox.Text = LunchMeal1.carb;

                meal2NameTextbox.Text = LunchMeal2.name;
                meal2CaloriesTextbox.Text = LunchMeal2.calories;
                meal2ProteinTextbox.Text = LunchMeal2.protein;
                meal2FatTextbox.Text = LunchMeal2.fat;
                meal2CarbTextbox.Text = LunchMeal2.carb;

                meal3NameTextbox.Text = LunchMeal3.name;
                meal3CaloriesTextbox.Text = LunchMeal3.calories;
                meal3ProteinTextbox.Text = LunchMeal3.protein;
                meal3FatTextBox.Text = LunchMeal3.fat;
                meal3CarbTextBox.Text = LunchMeal3.carb;

                sideMeal1NameTextbox.Text = SideMeal1Lunch.name;
                sideMeal1CaloriesTextbox.Text = SideMeal1Lunch.calories;
                sideMeal1CarbTextbox.Text = SideMeal1Lunch.carb;
                sideMeal1ProteinTextbox.Text = SideMeal1Lunch.protein;
                sideMeal1FatTextbox.Text = SideMeal1Lunch.fat;

                sideMeal2NameTextbox.Text = SideMeal2Lunch.name;
                sideMeal2CaloriesTextbox.Text = SideMeal2Lunch.calories;
                sideMeal2CarbTextbox.Text = SideMeal2Lunch.carb;
                sideMeal2ProteinTextbox.Text = SideMeal2Lunch.protein;
                sideMeal2FatTextbox.Text = SideMeal2Lunch.fat;

                sideMeal3NameTextbox.Text = SideMeal3Lunch.name;
                sideMeal3CaloriesTextbox.Text = SideMeal3Lunch.calories;
                sideMeal3CarbTextbox.Text = SideMeal3Lunch.carb;
                sideMeal3ProteinTextbox.Text = SideMeal3Lunch.protein;
                sideMeal3FatTextbox.Text = SideMeal3Lunch.fat;

                sauce1NameTextbox.Text = Sauce1Lunch.name;
                sauce1CalorieTextBox.Text = Sauce1Lunch.calories;
                sauce1ProteinTextBox.Text = Sauce1Lunch.protein;
                sauce1CarbTextBox.Text = Sauce1Lunch.carb;
                sauce1FatTextBox.Text = Sauce1Lunch.fat;

                sauce2NameTextbox.Text = Sauce2Lunch.name;
                sauce2CalorieTextBox.Text = Sauce2Lunch.calories;
                sauce2ProteinTextBox.Text = Sauce2Lunch.protein;
                sauce2CarbTextBox.Text = Sauce2Lunch.carb;
                sauce2FatTextBox.Text = Sauce2Lunch.fat;

                sauce3NameTextBox.Text = Sauce3Lunch.name;
                sauce3CalorieTextBox.Text = Sauce3Lunch.calories;
                sauce3ProteinTextBox.Text = Sauce3Lunch.protein;
                sauce3CarbTextBox.Text = Sauce3Lunch.carb;
                sauce3FatTextBox.Text = Sauce3Lunch.fat;

                sauce4NameTextBox.Text = Sauce4Lunch.name;
                sauce4CalorieTextBox.Text = Sauce4Lunch.calories;
                sauce4ProteinTextBox.Text = Sauce4Lunch.protein;
                sauce4CarbTextBox.Text = Sauce4Lunch.carb;
                sauce4FatTextBox.Text = Sauce4Lunch.fat;

                totalCaloriesTextbox.Text = TotalLunch.calories;
                totalProteinTextBox.Text = TotalLunch.protein;
                totalCarbTextBox.Text = TotalLunch.carb;
                totalFatTextBox.Text = TotalLunch.fat;
            }
            else if (comboBox.Text == "Dinner")
            {
                meal1NameTextbox.Text = DinnerMeal1.name;
                meal1CaloriesTextBox.Text = DinnerMeal1.calories;
                meal1ProteinTextBox.Text = DinnerMeal1.protein;
                meal1FatTextBox.Text = DinnerMeal1.fat;
                meal1CarbTextbox.Text = DinnerMeal1.carb;

                meal2NameTextbox.Text = DinnerMeal2.name;
                meal2CaloriesTextbox.Text = DinnerMeal2.calories;
                meal2ProteinTextbox.Text = DinnerMeal2.protein;
                meal2FatTextbox.Text = DinnerMeal2.fat;
                meal2CarbTextbox.Text = DinnerMeal2.carb;

                meal3NameTextbox.Text = DinnerMeal3.name;
                meal3CaloriesTextbox.Text = DinnerMeal3.calories;
                meal3ProteinTextbox.Text = DinnerMeal3.protein;
                meal3FatTextBox.Text = DinnerMeal3.fat;
                meal3CarbTextBox.Text = DinnerMeal3.carb;

                sideMeal1NameTextbox.Text = SideMeal1Dinner.name;
                sideMeal1CaloriesTextbox.Text = SideMeal1Dinner.calories;
                sideMeal1CarbTextbox.Text = SideMeal1Dinner.carb;
                sideMeal1ProteinTextbox.Text = SideMeal1Dinner.protein;
                sideMeal1FatTextbox.Text = SideMeal1Dinner.fat;

                sideMeal2NameTextbox.Text = SideMeal2Dinner.name;
                sideMeal2CaloriesTextbox.Text = SideMeal2Dinner.calories;
                sideMeal2CarbTextbox.Text = SideMeal2Dinner.carb;
                sideMeal2ProteinTextbox.Text = SideMeal2Dinner.protein;
                sideMeal2FatTextbox.Text = SideMeal2Dinner.fat;

                sideMeal3NameTextbox.Text = SideMeal3Dinner.name;
                sideMeal3CaloriesTextbox.Text = SideMeal3Dinner.calories;
                sideMeal3CarbTextbox.Text = SideMeal3Dinner.carb;
                sideMeal3ProteinTextbox.Text = SideMeal3Dinner.protein;
                sideMeal3FatTextbox.Text = SideMeal3Dinner.fat;

                sauce1NameTextbox.Text = Sauce1Dinner.name;
                sauce1CalorieTextBox.Text = Sauce1Dinner.calories;
                sauce1ProteinTextBox.Text = Sauce1Dinner.protein;
                sauce1CarbTextBox.Text = Sauce1Dinner.carb;
                sauce1FatTextBox.Text = Sauce1Dinner.fat;

                sauce2NameTextbox.Text = Sauce2Dinner.name;
                sauce2CalorieTextBox.Text = Sauce2Dinner.calories;
                sauce2ProteinTextBox.Text = Sauce2Dinner.protein;
                sauce2CarbTextBox.Text = Sauce2Dinner.carb;
                sauce2FatTextBox.Text = Sauce2Dinner.fat;

                sauce3NameTextBox.Text = Sauce3Dinner.name;
                sauce3CalorieTextBox.Text = Sauce3Dinner.calories;
                sauce3ProteinTextBox.Text = Sauce3Dinner.protein;
                sauce3CarbTextBox.Text = Sauce3Dinner.carb;
                sauce3FatTextBox.Text = Sauce3Dinner.fat;

                sauce4NameTextBox.Text = Sauce4Dinner.name;
                sauce4CalorieTextBox.Text = Sauce4Dinner.calories;
                sauce4ProteinTextBox.Text = Sauce4Dinner.protein;
                sauce4CarbTextBox.Text = Sauce4Dinner.carb;
                sauce4FatTextBox.Text = Sauce4Dinner.fat;

                totalCaloriesTextbox.Text = TotalDinner.calories;
                totalProteinTextBox.Text = TotalDinner.protein;
                totalCarbTextBox.Text = TotalDinner.carb;
                totalFatTextBox.Text = TotalDinner.fat;
            }
            CalculateTotal();
        }

        //static class to hold meal nutritions in meal times
        public static class BreakfastMeal1
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class BreakfastMeal2
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class BreakfastMeal3
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class LunchMeal1
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class LunchMeal2
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class LunchMeal3
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class DinnerMeal1
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class DinnerMeal2
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class DinnerMeal3
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class TotalBreakfast
        {
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class TotalLunch
        {
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class TotalDinner
        {
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class SideMeal1Breakfast
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class SideMeal1Lunch
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class SideMeal1Dinner
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class SideMeal2Breakfast
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class SideMeal2Lunch
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class SideMeal2Dinner
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class SideMeal3Breakfast
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class SideMeal3Lunch
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class SideMeal3Dinner
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce1Breakfast
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce1Lunch
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce1Dinner
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce2Breakfast
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce2Lunch
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce2Dinner
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce3Breakfast
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce3Lunch
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce3Dinner
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce4Breakfast
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce4Lunch
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        public static class Sauce4Dinner
        {
            public static string name;
            public static string calories = "0";
            public static string protein = "0";
            public static string carb = "0";
            public static string fat = "0";
        }
        //serving size and nutritions are stored here.
        public static class ServingSize
        {
            public static string servingSize = "0";
            //Calories in normal serving size of the meal
            public static string initialCalories = "0";
            public static string initialProtein = "0";
            public static string initialCarb = "0";
            public static string initialFat = "0";
        }

        //Calculates the total of every nutrition
        public void CalculateTotal()
        {
            try
            {
                //using calculateMeal method to calculate the total amount of nutritions by clicking confirm meal 
                decimal totalCalories = CalculateMeal(decimal.Parse(meal1CaloriesTextBox.Text), decimal.Parse(meal2CaloriesTextbox.Text),
                    decimal.Parse(meal3CaloriesTextbox.Text), decimal.Parse(sideMeal1CaloriesTextbox.Text),
                    decimal.Parse(sideMeal2CaloriesTextbox.Text), decimal.Parse(sideMeal3CaloriesTextbox.Text),
                    decimal.Parse(sauce1CalorieTextBox.Text), decimal.Parse(sauce2CalorieTextBox.Text), decimal.Parse(sauce3CalorieTextBox.Text),
                    decimal.Parse(sauce4CalorieTextBox.Text));
                decimal totalProtein = CalculateMeal(decimal.Parse(meal1ProteinTextBox.Text), decimal.Parse(meal2ProteinTextbox.Text),
                    decimal.Parse(meal3ProteinTextbox.Text), decimal.Parse(sideMeal1ProteinTextbox.Text),
                    decimal.Parse(sideMeal2ProteinTextbox.Text), decimal.Parse(sideMeal3ProteinTextbox.Text), decimal.Parse(sauce1ProteinTextBox.Text),
                    decimal.Parse(sauce2ProteinTextBox.Text), decimal.Parse(sauce3ProteinTextBox.Text),
                    decimal.Parse(sauce4ProteinTextBox.Text));
                decimal totalCarb = CalculateMeal(decimal.Parse(meal1CarbTextbox.Text), decimal.Parse(meal2CarbTextbox.Text),
                    decimal.Parse(meal3CarbTextBox.Text), decimal.Parse(sideMeal1CarbTextbox.Text), decimal.Parse(sideMeal2CarbTextbox.Text),
                    decimal.Parse(sideMeal3CarbTextbox.Text), decimal.Parse(sauce1CarbTextBox.Text), decimal.Parse(sauce2CarbTextBox.Text),
                    decimal.Parse(sauce3CarbTextBox.Text), decimal.Parse(sauce4CarbTextBox.Text));
                decimal totalFat = CalculateMeal(decimal.Parse(meal1FatTextBox.Text), decimal.Parse(meal2FatTextbox.Text), decimal.Parse(meal3FatTextBox.Text),
                    decimal.Parse(sideMeal1FatTextbox.Text), decimal.Parse(sideMeal2FatTextbox.Text), decimal.Parse(sideMeal3FatTextbox.Text),
                    decimal.Parse(sauce1FatTextBox.Text), decimal.Parse(sauce2FatTextBox.Text), decimal.Parse(sauce3FatTextBox.Text),
                    decimal.Parse(sauce4FatTextBox.Text)); ;
                //output to related text boxes
                totalCaloriesTextbox.Text = totalCalories.ToString();
                totalProteinTextBox.Text = totalProtein.ToString();
                totalCarbTextBox.Text = totalCarb.ToString();
                totalFatTextBox.Text = totalFat.ToString();
            }
            catch (Exception exc)
            {

                MessageBox.Show("Error Occured: " + exc);
            }
        }
        //Generating Rdi after meal calculation
        private void generateTotalChartButton_Click(object sender, EventArgs e)
        {

            //if the textbox is empty then output an error message
            if (totalCaloriesTextbox.Text == "")
            {
                MessageBox.Show("You haven't got any meals chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //generating the Calorie breakdown Chart
                    CalorieBreakdown(totalFatTextBox.Text, totalCarbTextBox.Text, totalProteinTextBox.Text, totalCaloriesTextbox.Text);
                    GenerateCalorieGraph();
                    //output for calorie breakdown
                    calorieLabel.Text = "There are " + totalCaloriesTextbox.Text + " Calories";
                    caloriebreakdownLabel.Text = caloriebreakdownLabel.Text = "Calorie breakdown: " + comboBox.SelectedItem.ToString() + Environment.NewLine
                         + doubleTotalProteinPercentage + "% Protein"
                            + Environment.NewLine + doubleTotalCarbPercentage
                            + "% Carbohydrate" + Environment.NewLine + doubleTotalFatPercentage + "% Fat";

                }
                catch (Exception)
                {

                }
            }

            //if rdi is smaller than calories then output a message
            if (decimal.Parse(inputRdiMealCalculatorTextBox.Text) < decimal.Parse(totalCaloriesTextbox.Text))
            {
                //rdi check is true
                RDICheck(decimal.Parse(inputRdiMealCalculatorTextBox.Text), decimal.Parse(totalCaloriesTextbox.Text));
                //calorie surpassed so calculates the amount of the overdose
                decimal surpass = Math.Round(CalorieSurpass(decimal.Parse(totalCaloriesTextbox.Text), decimal.Parse(inputRdiMealCalculatorTextBox.Text)));
                rdiLabel.Text = "The amount of calorie intake have surpassed" + Environment.NewLine + " by %" + surpass.ToString();
            }

            else
            {
                try
                {
                    //generating the RDI chart
                    GenerateRDIChart(int.Parse(inputRdiMealCalculatorTextBox.Text), int.Parse(totalCaloriesTextbox.Text));
                    //if the rdi textbox is not empty then calculate it by the input.
                    decimal rdiPercentage = CalculateRDIPercentage(decimal.Parse(inputRdiMealCalculatorTextBox.Text), decimal.Parse(totalCaloriesTextbox.Text));
                    rdiLabel.Text = Math.Round(rdiPercentage).ToString() + "% on a RDI of " + inputRdiMealCalculatorTextBox.Text + " calories.";

                }
                catch (Exception)
                {

                    MessageBox.Show("Error: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Charts are created! Please check the 'Charts' Tab!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        //Calculates the percentage of nutritions based on the input and the class Calorie_Breakdown 
        public void CalorieBreakdown(string fat, string carb, string protein, string calories)
        {
            decimal fatCalories = Calorie_Breakdown.fatToCalories(decimal.Parse(fat));
            decimal totalFatPercentage = Calorie_Breakdown.caloriesInFat(fatCalories, decimal.Parse(calories));
            doubleTotalFatPercentage = double.Parse(Math.Round(totalFatPercentage).ToString());

            decimal carbCalories = Calorie_Breakdown.carbToCalories(decimal.Parse(carb));
            decimal totalCarbPercentage = Calorie_Breakdown.caloriesInCarb(carbCalories, decimal.Parse(calories));
            doubleTotalCarbPercentage = double.Parse(Math.Round(totalCarbPercentage).ToString());

            decimal proteinCalories = Calorie_Breakdown.proteinToCalories(decimal.Parse(protein));
            decimal totalProteinPercentage = Calorie_Breakdown.caloriesinProtein(proteinCalories, decimal.Parse(calories));
            doubleTotalProteinPercentage = double.Parse(Math.Round(totalProteinPercentage).ToString());
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

        private void confirmSide1Button_Click(object sender, EventArgs e)
        {
            //whatever is in the nutrition summary text boxes it copies to meal textboxes
            sideMeal1NameTextbox.Text = listBox.GetItemText(listBox.SelectedItem);
            sideMeal1CaloriesTextbox.Text = caloriesTextbox.Text;
            sideMeal1ProteinTextbox.Text = proteinTextbox.Text;
            sideMeal1FatTextbox.Text = fatTextbox.Text;
            sideMeal1CarbTextbox.Text = carbTextbox.Text;

            if (comboBox.Text == "")
            {
                MessageBox.Show("Please choose your Meal Time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Meal!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //saving it to static classes
            else if (comboBox.Text == "Breakfast")
            {
                SideMeal1Breakfast.name = sideMeal1NameTextbox.Text;
                SideMeal1Breakfast.calories = sideMeal1CaloriesTextbox.Text;
                SideMeal1Breakfast.protein = sideMeal1ProteinTextbox.Text;
                SideMeal1Breakfast.fat = sideMeal1FatTextbox.Text;
                SideMeal1Breakfast.carb = sideMeal1CarbTextbox.Text;

                TotalBreakfast.calories = totalCaloriesTextbox.Text;
                TotalBreakfast.protein = totalProteinTextBox.Text;
                TotalBreakfast.carb = totalCarbTextBox.Text;
                TotalBreakfast.fat = totalFatTextBox.Text;

            }
            else if (comboBox.Text == "Lunch")
            {
                SideMeal1Lunch.name = sideMeal1NameTextbox.Text;
                SideMeal1Lunch.calories = sideMeal1CaloriesTextbox.Text;
                SideMeal1Lunch.protein = sideMeal1ProteinTextbox.Text;
                SideMeal1Lunch.fat = sideMeal1FatTextbox.Text;
                SideMeal1Lunch.carb = sideMeal1CarbTextbox.Text;

                TotalLunch.calories = totalCaloriesTextbox.Text;
                TotalLunch.protein = totalProteinTextBox.Text;
                TotalLunch.carb = totalCarbTextBox.Text;
                TotalLunch.fat = totalFatTextBox.Text;
            }
            else if (comboBox.Text == "Dinner")
            {
                SideMeal1Dinner.name = sideMeal1NameTextbox.Text;
                SideMeal1Dinner.calories = sideMeal1CaloriesTextbox.Text;
                SideMeal1Dinner.protein = sideMeal1ProteinTextbox.Text;
                SideMeal1Dinner.fat = sideMeal1FatTextbox.Text;
                SideMeal1Dinner.carb = sideMeal1CarbTextbox.Text;

                TotalDinner.calories = totalCaloriesTextbox.Text;
                TotalDinner.protein = totalProteinTextBox.Text;
                TotalDinner.carb = totalCarbTextBox.Text;
                TotalDinner.fat = totalFatTextBox.Text;
            }
            CalculateTotal();

        }

        private void confirmSide2Button_Click(object sender, EventArgs e)
        {
            //whatever is in the nutrition summary text boxes it copies to meal textboxes
            sideMeal2NameTextbox.Text = listBox.GetItemText(listBox.SelectedItem);
            sideMeal2CaloriesTextbox.Text = caloriesTextbox.Text;
            sideMeal2ProteinTextbox.Text = proteinTextbox.Text;
            sideMeal2FatTextbox.Text = fatTextbox.Text;
            sideMeal2CarbTextbox.Text = carbTextbox.Text;

            if (comboBox.Text == "")
            {
                MessageBox.Show("Please choose your Meal Time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Meal!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBox.Text == "Breakfast")
            {
                //saving the textboxes to static variables
                SideMeal2Breakfast.name = sideMeal2NameTextbox.Text;
                SideMeal2Breakfast.calories = sideMeal2CaloriesTextbox.Text;
                SideMeal2Breakfast.protein = sideMeal2ProteinTextbox.Text;
                SideMeal2Breakfast.fat = sideMeal2FatTextbox.Text;
                SideMeal2Breakfast.carb = sideMeal2CarbTextbox.Text;

                TotalBreakfast.calories = totalCaloriesTextbox.Text;
                TotalBreakfast.protein = totalProteinTextBox.Text;
                TotalBreakfast.carb = totalCarbTextBox.Text;
                TotalBreakfast.fat = totalFatTextBox.Text;

            }
            else if (comboBox.Text == "Lunch")
            {
                SideMeal2Lunch.name = sideMeal2NameTextbox.Text;
                SideMeal2Lunch.calories = sideMeal2CaloriesTextbox.Text;
                SideMeal2Lunch.protein = sideMeal2ProteinTextbox.Text;
                SideMeal2Lunch.fat = sideMeal2FatTextbox.Text;
                SideMeal2Lunch.carb = sideMeal2CarbTextbox.Text;

                TotalLunch.calories = totalCaloriesTextbox.Text;
                TotalLunch.protein = totalProteinTextBox.Text;
                TotalLunch.carb = totalCarbTextBox.Text;
                TotalLunch.fat = totalFatTextBox.Text;
            }
            else if (comboBox.Text == "Dinner")
            {
                SideMeal2Dinner.name = sideMeal2NameTextbox.Text;
                SideMeal2Dinner.calories = sideMeal2CaloriesTextbox.Text;
                SideMeal2Dinner.protein = sideMeal2ProteinTextbox.Text;
                SideMeal2Dinner.fat = sideMeal2FatTextbox.Text;
                SideMeal2Dinner.carb = sideMeal2CarbTextbox.Text;

                TotalDinner.calories = totalCaloriesTextbox.Text;
                TotalDinner.protein = totalProteinTextBox.Text;
                TotalDinner.carb = totalCarbTextBox.Text;
                TotalDinner.fat = totalFatTextBox.Text;
            }
            CalculateTotal();

        }


        private void confirmSide3Button_Click(object sender, EventArgs e)
        {
            //whatever is in the nutrition summary text boxes it copies to meal textboxes
            sideMeal3NameTextbox.Text = listBox.GetItemText(listBox.SelectedItem);
            sideMeal3CaloriesTextbox.Text = caloriesTextbox.Text;
            sideMeal3ProteinTextbox.Text = proteinTextbox.Text;
            sideMeal3FatTextbox.Text = fatTextbox.Text;
            sideMeal3CarbTextbox.Text = carbTextbox.Text;

            if (comboBox.Text == "")
            {
                MessageBox.Show("Please choose your Meal Time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Meal!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBox.Text == "Breakfast")
            {
                //saving the textboxes to static variables
                SideMeal3Breakfast.name = sideMeal3NameTextbox.Text;
                SideMeal3Breakfast.calories = sideMeal3CaloriesTextbox.Text;
                SideMeal3Breakfast.protein = sideMeal3ProteinTextbox.Text;
                SideMeal3Breakfast.fat = sideMeal3FatTextbox.Text;
                SideMeal3Breakfast.carb = sideMeal3CarbTextbox.Text;

                TotalBreakfast.calories = totalCaloriesTextbox.Text;
                TotalBreakfast.protein = totalProteinTextBox.Text;
                TotalBreakfast.carb = totalCarbTextBox.Text;
                TotalBreakfast.fat = totalFatTextBox.Text;

            }
            else if (comboBox.Text == "Lunch")
            {
                SideMeal3Lunch.name = sideMeal3NameTextbox.Text;
                SideMeal3Lunch.calories = sideMeal3CaloriesTextbox.Text;
                SideMeal3Lunch.protein = sideMeal3ProteinTextbox.Text;
                SideMeal3Lunch.fat = sideMeal3FatTextbox.Text;
                SideMeal3Lunch.carb = sideMeal3CarbTextbox.Text;

                TotalLunch.calories = totalCaloriesTextbox.Text;
                TotalLunch.protein = totalProteinTextBox.Text;
                TotalLunch.carb = totalCarbTextBox.Text;
                TotalLunch.fat = totalFatTextBox.Text;
            }
            else if (comboBox.Text == "Dinner")
            {
                SideMeal3Dinner.name = sideMeal3NameTextbox.Text;
                SideMeal3Dinner.calories = sideMeal3CaloriesTextbox.Text;
                SideMeal3Dinner.protein = sideMeal3ProteinTextbox.Text;
                SideMeal3Dinner.fat = sideMeal3FatTextbox.Text;
                SideMeal3Dinner.carb = sideMeal3CarbTextbox.Text;

                TotalDinner.calories = totalCaloriesTextbox.Text;
                TotalDinner.protein = totalProteinTextBox.Text;
                TotalDinner.carb = totalCarbTextBox.Text;
                TotalDinner.fat = totalFatTextBox.Text;
            }
            CalculateTotal();
        }
        //disposal
        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset EVERYTHING?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    comboBox.SelectedItem = null;
                    inputTextbox.Text = "";
                    listBox.SelectedItem = null;
                    //reset meal names
                    meal1NameTextbox.Text = "";
                    meal2NameTextbox.Text = "";
                    meal3NameTextbox.Text = "";
                    sideMeal1NameTextbox.Text = "";
                    sideMeal2NameTextbox.Text = "";
                    sideMeal3NameTextbox.Text = "";
                    sauce1NameTextbox.Text = "";
                    sauce2NameTextbox.Text = "";
                    sauce3NameTextBox.Text = "";
                    sauce4NameTextBox.Text = "";

                    //setting meal calculator textbox to 0 
                    meal1CaloriesTextBox.Text = "0";
                    meal1ProteinTextBox.Text = "0";
                    meal1CarbTextbox.Text = "0";
                    meal1FatTextBox.Text = "0";
                    meal2CaloriesTextbox.Text = "0";
                    meal2ProteinTextbox.Text = "0";
                    meal2CarbTextbox.Text = "0";
                    meal2FatTextbox.Text = "0";
                    meal3CaloriesTextbox.Text = "0";
                    meal3ProteinTextbox.Text = "0";
                    meal3CarbTextBox.Text = "0";
                    meal3FatTextBox.Text = "0";
                    sideMeal1CaloriesTextbox.Text = "0";
                    sideMeal1ProteinTextbox.Text = "0";
                    sideMeal1CarbTextbox.Text = "0";
                    sideMeal1FatTextbox.Text = "0";
                    sideMeal2CaloriesTextbox.Text = "0";
                    sideMeal2ProteinTextbox.Text = "0";
                    sideMeal2CarbTextbox.Text = "0";
                    sideMeal2FatTextbox.Text = "0";
                    sideMeal3CaloriesTextbox.Text = "0";
                    sideMeal3ProteinTextbox.Text = "0";
                    sideMeal3CarbTextbox.Text = "0";
                    sideMeal3FatTextbox.Text = "0";
                    sauce1CalorieTextBox.Text = "0";
                    sauce1CarbTextBox.Text = "0";
                    sauce1ProteinTextBox.Text = "0";
                    sauce1FatTextBox.Text = "0";
                    sauce2CalorieTextBox.Text = "0";
                    sauce2CarbTextBox.Text = "0";
                    sauce2ProteinTextBox.Text = "0";
                    sauce2FatTextBox.Text = "0";
                    sauce3CalorieTextBox.Text = "0";
                    sauce3CarbTextBox.Text = "0";
                    sauce3ProteinTextBox.Text = "0";
                    sauce3FatTextBox.Text = "0";
                    sauce4CalorieTextBox.Text = "0";
                    sauce4CarbTextBox.Text = "0";
                    sauce4ProteinTextBox.Text = "0";
                    sauce4FatTextBox.Text = "0";
                    //setting total nutrition summary textbox to 0
                    totalCaloriesTextbox.Text = "0";
                    totalProteinTextBox.Text = "0";
                    totalCarbTextBox.Text = "0";
                    totalFatTextBox.Text = "0";
                    //setting nutrition summary textbox to 0
                    quantityTextbox.Text = "0";
                    caloriesTextbox.Text = "0";
                    proteinTextbox.Text = "0";
                    carbTextbox.Text = "0";
                    fatTextbox.Text = "0";
                    //rdi textboxes
                    inputRdiTextBox.Text = "2000";
                    inputRdiMealCalculatorTextBox.Text = "2000";
                    //calorie breakdown and rdi labels
                    caloriebreakdownLabel.Text = "";
                    calorieLabel.Text = "";
                    rdiLabel.Text = "";
                    //charts reset
                    rdiChart.Series[0].Points.Clear();
                    calorieChart.Series[0].Points.Clear();
                    //dispose the static data 
                    BreakfastMeal1.name = "";
                    BreakfastMeal1.calories = "0";
                    BreakfastMeal1.protein = "0";
                    BreakfastMeal1.fat = "0";
                    BreakfastMeal1.carb = "0";
                    BreakfastMeal2.name = "";
                    BreakfastMeal2.calories = "0";
                    BreakfastMeal2.protein = "0";
                    BreakfastMeal2.carb = "0";
                    BreakfastMeal2.fat = "0";
                    BreakfastMeal3.name = "";
                    BreakfastMeal3.calories = "0";
                    BreakfastMeal3.protein = "0";
                    BreakfastMeal3.carb = "0";
                    BreakfastMeal3.fat = "0";
                    TotalBreakfast.calories = "0";
                    TotalBreakfast.protein = "0";
                    TotalBreakfast.carb = "0";
                    TotalBreakfast.fat = "0";
                    LunchMeal1.name = "";
                    LunchMeal1.calories = "0";
                    LunchMeal1.protein = "0";
                    LunchMeal1.fat = "0";
                    LunchMeal1.carb = "0";
                    LunchMeal2.name = "";
                    LunchMeal2.calories = "0";
                    LunchMeal2.protein = "0";
                    LunchMeal2.carb = "0";
                    LunchMeal2.fat = "0";
                    LunchMeal3.name = "";
                    LunchMeal3.calories = "0";
                    LunchMeal3.protein = "0";
                    LunchMeal3.carb = "0";
                    LunchMeal3.fat = "0";
                    TotalLunch.calories = "0";
                    TotalLunch.protein = "0";
                    TotalLunch.carb = "0";
                    DinnerMeal1.name = "";
                    DinnerMeal1.calories = "0";
                    DinnerMeal1.protein = "0";
                    DinnerMeal1.fat = "0";
                    DinnerMeal1.carb = "0";
                    DinnerMeal2.name = "";
                    DinnerMeal2.calories = "0";
                    DinnerMeal2.protein = "0";
                    DinnerMeal2.carb = "0";
                    DinnerMeal2.fat = "0";
                    DinnerMeal3.name = "";
                    DinnerMeal3.calories = "0";
                    DinnerMeal3.protein = "0";
                    DinnerMeal3.carb = "0";
                    DinnerMeal3.fat = "0";
                    TotalDinner.calories = "0";
                    TotalDinner.protein = "0";
                    TotalDinner.carb = "0";
                    TotalDinner.fat = "0";
                    SideMeal1Breakfast.name = "";
                    SideMeal1Breakfast.calories = "0";
                    SideMeal1Breakfast.protein = "0";
                    SideMeal1Breakfast.fat = "0";
                    SideMeal1Breakfast.carb = "0";
                    SideMeal2Breakfast.name = "";
                    SideMeal2Breakfast.calories = "0";
                    SideMeal2Breakfast.protein = "0";
                    SideMeal2Breakfast.fat = "0";
                    SideMeal2Breakfast.carb = "0";
                    SideMeal1Lunch.name = "";
                    SideMeal1Lunch.calories = "0";
                    SideMeal1Lunch.protein = "0";
                    SideMeal1Lunch.fat = "0";
                    SideMeal1Lunch.carb = "0";
                    SideMeal2Lunch.name = "";
                    SideMeal2Lunch.calories = "0";
                    SideMeal2Lunch.protein = "0";
                    SideMeal2Lunch.fat = "0";
                    SideMeal2Lunch.carb = "0";
                    SideMeal1Dinner.name = "";
                    SideMeal1Dinner.calories = "0";
                    SideMeal1Dinner.protein = "0";
                    SideMeal1Dinner.fat = "0";
                    SideMeal1Dinner.carb = "0";
                    SideMeal2Dinner.name = "";
                    SideMeal2Dinner.calories = "0";
                    SideMeal2Dinner.protein = "0";
                    SideMeal2Dinner.fat = "0";
                    SideMeal2Dinner.carb = "0";
                    Sauce1Breakfast.name = "";
                    Sauce1Breakfast.calories = "0";
                    Sauce1Breakfast.protein = "0";
                    Sauce1Breakfast.carb = "0";
                    Sauce1Breakfast.fat = "0";
                    Sauce2Breakfast.name = "";
                    Sauce2Breakfast.calories = "0";
                    Sauce2Breakfast.protein = "0";
                    Sauce2Breakfast.carb = "0";
                    Sauce2Breakfast.fat = "0";
                    Sauce3Breakfast.name = "";
                    Sauce3Breakfast.calories = "0";
                    Sauce3Breakfast.protein = "0";
                    Sauce3Breakfast.carb = "0";
                    Sauce3Breakfast.fat = "0";
                    Sauce4Breakfast.name = "";
                    Sauce4Breakfast.calories = "0";
                    Sauce4Breakfast.protein = "0";
                    Sauce4Breakfast.carb = "0";
                    Sauce4Breakfast.fat = "0";
                    Sauce1Lunch.name = "";
                    Sauce1Lunch.calories = "0";
                    Sauce1Lunch.protein = "0";
                    Sauce1Lunch.carb = "0";
                    Sauce1Lunch.fat = "0";
                    Sauce2Lunch.name = "";
                    Sauce2Lunch.calories = "0";
                    Sauce2Lunch.protein = "0";
                    Sauce2Lunch.carb = "0";
                    Sauce2Lunch.fat = "0";
                    Sauce3Lunch.name = "";
                    Sauce3Lunch.calories = "0";
                    Sauce3Lunch.protein = "0";
                    Sauce3Lunch.carb = "0";
                    Sauce3Lunch.fat = "0";
                    Sauce4Lunch.name = "";
                    Sauce4Lunch.calories = "0";
                    Sauce4Lunch.protein = "0";
                    Sauce4Lunch.carb = "0";
                    Sauce4Lunch.fat = "0";
                    Sauce1Dinner.name = "";
                    Sauce1Dinner.calories = "0";
                    Sauce1Dinner.protein = "0";
                    Sauce1Dinner.carb = "0";
                    Sauce1Dinner.fat = "0";
                    Sauce2Dinner.name = "";
                    Sauce2Dinner.calories = "0";
                    Sauce2Dinner.protein = "0";
                    Sauce2Dinner.carb = "0";
                    Sauce2Dinner.fat = "0";
                    Sauce3Dinner.name = "";
                    Sauce3Dinner.calories = "0";
                    Sauce3Dinner.protein = "0";
                    Sauce3Dinner.carb = "0";
                    Sauce3Dinner.fat = "0";
                    Sauce4Dinner.name = "";
                    Sauce4Dinner.calories = "0";
                    Sauce4Dinner.protein = "0";
                    Sauce4Dinner.carb = "0";
                    Sauce4Dinner.fat = "0";

                    ServingSize.servingSize = "0";
                    ServingSize.initialCalories = "0";
                    ServingSize.initialProtein = "0";
                    ServingSize.initialCarb = "0";
                    ServingSize.initialFat = "0";

                }
                catch (Exception)
                {

                    MessageBox.Show("Error Occurred: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //confirming sauces
        private void confirmSauce1Button_Click(object sender, EventArgs e)
        {
            //whatever is in the nutrition summary text boxes it copies to sauce textboxes
            sauce1NameTextbox.Text = listBox.GetItemText(listBox.SelectedItem);
            sauce1CalorieTextBox.Text = caloriesTextbox.Text;
            sauce1ProteinTextBox.Text = proteinTextbox.Text;
            sauce1CarbTextBox.Text = carbTextbox.Text;
            sauce1FatTextBox.Text = fatTextbox.Text;


            if (comboBox.Text == "")
            {
                MessageBox.Show("Please choose your Meal Time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select any Sauce!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBox.Text == "Breakfast")
            {
                Sauce1Breakfast.name = sauce1NameTextbox.Text;
                Sauce1Breakfast.calories = sauce1CalorieTextBox.Text;
                Sauce1Breakfast.protein = sauce1ProteinTextBox.Text;
                Sauce1Breakfast.carb = sauce1CarbTextBox.Text;
                Sauce1Breakfast.fat = sauce1FatTextBox.Text;

                TotalBreakfast.calories = totalCaloriesTextbox.Text;
                TotalBreakfast.protein = totalProteinTextBox.Text;
                TotalBreakfast.carb = totalCarbTextBox.Text;
                TotalBreakfast.fat = totalFatTextBox.Text;

            }
            else if (comboBox.Text == "Lunch")
            {
                Sauce1Lunch.name = sauce1NameTextbox.Text;
                Sauce1Lunch.calories = sauce1CalorieTextBox.Text;
                Sauce1Lunch.protein = sauce1ProteinTextBox.Text;
                Sauce1Lunch.carb = sauce1CarbTextBox.Text;
                Sauce1Lunch.fat = sauce1FatTextBox.Text;

                TotalLunch.calories = totalCaloriesTextbox.Text;
                TotalLunch.protein = totalProteinTextBox.Text;
                TotalLunch.carb = totalCarbTextBox.Text;
                TotalLunch.fat = totalFatTextBox.Text;
            }
            else if (comboBox.Text == "Dinner")
            {
                Sauce1Dinner.name = sauce1NameTextbox.Text;
                Sauce1Dinner.calories = sauce1CalorieTextBox.Text;
                Sauce1Dinner.protein = sauce1ProteinTextBox.Text;
                Sauce1Dinner.carb = sauce1CarbTextBox.Text;
                Sauce1Dinner.fat = sauce1FatTextBox.Text;

                TotalDinner.calories = totalCaloriesTextbox.Text;
                TotalDinner.protein = totalProteinTextBox.Text;
                TotalDinner.carb = totalCarbTextBox.Text;
                TotalDinner.fat = totalFatTextBox.Text;
            }

            CalculateTotal();
        }
        private void confirmSauce2Button_Click(object sender, EventArgs e)
        {
            //whatever is in the nutrition summary text boxes it copies to sauce textboxes
            sauce2NameTextbox.Text = listBox.GetItemText(listBox.SelectedItem);
            sauce2CalorieTextBox.Text = caloriesTextbox.Text;
            sauce2ProteinTextBox.Text = proteinTextbox.Text;
            sauce2CarbTextBox.Text = carbTextbox.Text;
            sauce2FatTextBox.Text = fatTextbox.Text;


            if (comboBox.Text == "")
            {
                MessageBox.Show("Please choose your Meal Time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select any Sauce!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBox.Text == "Breakfast")
            {
                Sauce2Breakfast.name = sauce2NameTextbox.Text;
                Sauce2Breakfast.calories = sauce2CalorieTextBox.Text;
                Sauce2Breakfast.protein = sauce2ProteinTextBox.Text;
                Sauce2Breakfast.carb = sauce2CarbTextBox.Text;
                Sauce2Breakfast.fat = sauce2FatTextBox.Text;

                TotalBreakfast.calories = totalCaloriesTextbox.Text;
                TotalBreakfast.protein = totalProteinTextBox.Text;
                TotalBreakfast.carb = totalCarbTextBox.Text;
                TotalBreakfast.fat = totalFatTextBox.Text;

            }
            else if (comboBox.Text == "Lunch")
            {
                Sauce2Lunch.name = sauce2NameTextbox.Text;
                Sauce2Lunch.calories = sauce2CalorieTextBox.Text;
                Sauce2Lunch.protein = sauce2ProteinTextBox.Text;
                Sauce2Lunch.carb = sauce2CarbTextBox.Text;
                Sauce2Lunch.fat = sauce2FatTextBox.Text;

                TotalLunch.calories = totalCaloriesTextbox.Text;
                TotalLunch.protein = totalProteinTextBox.Text;
                TotalLunch.carb = totalCarbTextBox.Text;
                TotalLunch.fat = totalFatTextBox.Text;
            }
            else if (comboBox.Text == "Dinner")
            {
                Sauce2Dinner.name = sauce2NameTextbox.Text;
                Sauce2Dinner.calories = sauce2CalorieTextBox.Text;
                Sauce2Dinner.protein = sauce2ProteinTextBox.Text;
                Sauce2Dinner.carb = sauce2CarbTextBox.Text;
                Sauce2Dinner.fat = sauce2FatTextBox.Text;

                TotalDinner.calories = totalCaloriesTextbox.Text;
                TotalDinner.protein = totalProteinTextBox.Text;
                TotalDinner.carb = totalCarbTextBox.Text;
                TotalDinner.fat = totalFatTextBox.Text;
            }

            CalculateTotal();
        }
        private void confirmSauce3Button_Click(object sender, EventArgs e)
        {
            //whatever is in the nutrition summary text boxes it copies to sauce textboxes
            sauce3NameTextBox.Text = listBox.GetItemText(listBox.SelectedItem);
            sauce3CalorieTextBox.Text = caloriesTextbox.Text;
            sauce3ProteinTextBox.Text = proteinTextbox.Text;
            sauce3CarbTextBox.Text = carbTextbox.Text;
            sauce3FatTextBox.Text = fatTextbox.Text;


            if (comboBox.Text == "")
            {
                MessageBox.Show("Please choose your Meal Time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select any Sauce!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBox.Text == "Breakfast")
            {
                Sauce3Breakfast.name = sauce3NameTextBox.Text;
                Sauce3Breakfast.calories = sauce3CalorieTextBox.Text;
                Sauce3Breakfast.protein = sauce3ProteinTextBox.Text;
                Sauce3Breakfast.carb = sauce3CarbTextBox.Text;
                Sauce3Breakfast.fat = sauce3FatTextBox.Text;

                TotalBreakfast.calories = totalCaloriesTextbox.Text;
                TotalBreakfast.protein = totalProteinTextBox.Text;
                TotalBreakfast.carb = totalCarbTextBox.Text;
                TotalBreakfast.fat = totalFatTextBox.Text;

            }
            else if (comboBox.Text == "Lunch")
            {
                Sauce3Lunch.name = sauce3NameTextBox.Text;
                Sauce3Lunch.calories = sauce3CalorieTextBox.Text;
                Sauce3Lunch.protein = sauce3ProteinTextBox.Text;
                Sauce3Lunch.carb = sauce3CarbTextBox.Text;
                Sauce3Lunch.fat = sauce3FatTextBox.Text;

                TotalLunch.calories = totalCaloriesTextbox.Text;
                TotalLunch.protein = totalProteinTextBox.Text;
                TotalLunch.carb = totalCarbTextBox.Text;
                TotalLunch.fat = totalFatTextBox.Text;
            }
            else if (comboBox.Text == "Dinner")
            {
                Sauce3Dinner.name = sauce3NameTextBox.Text;
                Sauce3Dinner.calories = sauce3CalorieTextBox.Text;
                Sauce3Dinner.protein = sauce3ProteinTextBox.Text;
                Sauce3Dinner.carb = sauce3CarbTextBox.Text;
                Sauce3Dinner.fat = sauce3FatTextBox.Text;

                TotalDinner.calories = totalCaloriesTextbox.Text;
                TotalDinner.protein = totalProteinTextBox.Text;
                TotalDinner.carb = totalCarbTextBox.Text;
                TotalDinner.fat = totalFatTextBox.Text;
            }

            CalculateTotal();
        }
        private void confirmSauce4Button_Click(object sender, EventArgs e)
        {
            //whatever is in the nutrition summary text boxes it copies to sauce textboxes
            sauce4NameTextBox.Text = listBox.GetItemText(listBox.SelectedItem);
            sauce4CalorieTextBox.Text = caloriesTextbox.Text;
            sauce4ProteinTextBox.Text = proteinTextbox.Text;
            sauce4CarbTextBox.Text = carbTextbox.Text;
            sauce4FatTextBox.Text = fatTextbox.Text;


            if (comboBox.Text == "")
            {
                MessageBox.Show("Please choose your Meal Time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select any Sauce!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBox.Text == "Breakfast")
            {
                Sauce4Breakfast.name = sauce4NameTextBox.Text;
                Sauce4Breakfast.calories = sauce4CalorieTextBox.Text;
                Sauce4Breakfast.protein = sauce4ProteinTextBox.Text;
                Sauce4Breakfast.carb = sauce4CarbTextBox.Text;
                Sauce4Breakfast.fat = sauce4FatTextBox.Text;

                TotalBreakfast.calories = totalCaloriesTextbox.Text;
                TotalBreakfast.protein = totalProteinTextBox.Text;
                TotalBreakfast.carb = totalCarbTextBox.Text;
                TotalBreakfast.fat = totalFatTextBox.Text;

            }
            else if (comboBox.Text == "Lunch")
            {
                Sauce4Lunch.name = sauce4NameTextBox.Text;
                Sauce4Lunch.calories = sauce4CalorieTextBox.Text;
                Sauce4Lunch.protein = sauce4ProteinTextBox.Text;
                Sauce4Lunch.carb = sauce4CarbTextBox.Text;
                Sauce4Lunch.fat = sauce4FatTextBox.Text;

                TotalLunch.calories = totalCaloriesTextbox.Text;
                TotalLunch.protein = totalProteinTextBox.Text;
                TotalLunch.carb = totalCarbTextBox.Text;
                TotalLunch.fat = totalFatTextBox.Text;
            }
            else if (comboBox.Text == "Dinner")
            {
                Sauce4Dinner.name = sauce4NameTextBox.Text;
                Sauce4Dinner.calories = sauce4CalorieTextBox.Text;
                Sauce4Dinner.protein = sauce4ProteinTextBox.Text;
                Sauce4Dinner.carb = sauce4CarbTextBox.Text;
                Sauce4Dinner.fat = sauce4FatTextBox.Text;

                TotalDinner.calories = totalCaloriesTextbox.Text;
                TotalDinner.protein = totalProteinTextBox.Text;
                TotalDinner.carb = totalCarbTextBox.Text;
                TotalDinner.fat = totalFatTextBox.Text;
            }

            CalculateTotal();
        }

        private void bMRCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMRForm bmr = new BMRForm();
            bmr.ShowDialog();
        }
    }
}



