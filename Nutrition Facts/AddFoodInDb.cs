using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nutrition_Facts
{
    public partial class AddFoodInDb : Form
    {
        public AddFoodInDb()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextbox.Text;
            string cal = calorieTextbox.Text;
            string pro = proteinTextbox.Text;
            string carb = carbTextBox.Text;
            string fat = fatTextbox.Text;
            string qua = quantityTextbox.Text;


            if (nameTextbox.Text.Equals("") || quantityTextbox.Text.Equals("") || calorieTextbox.Text.Equals("")
                || proteinTextbox.Text.Equals("") || carbTextBox.Text.Equals("") || fatTextbox.Text.Equals(""))
            {

                MessageBox.Show("Fields cannot be empty");
            }
            else
            {

                //connection
                SqlConnection connString = DatabaseClass.GetConnection();

                try
                {
                    connString.Open();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception in DBHandler", ex);
                }
                // select all from facts table where the data matches with the text box variable'Name' 
                string myQuery = "Select * From Facts Where Name = '" + name + "'";
                SqlCommand myCommand = new SqlCommand(myQuery, connString);
                myCommand.ExecuteNonQuery();
                SqlDataReader dataReader = myCommand.ExecuteReader();
                //if the data exists in the database then output a message
                if (dataReader.HasRows)
                {
                    MessageBox.Show("This already exists");

                }

                else
                {
                    try
                    {
                        //if not then add the data in facts table
                        DatabaseClass.InsertFoods(name, cal, pro, carb, fat, qua);
                        MessageBox.Show("Added Successfully");
                        nameTextbox.Text = "";
                        proteinTextbox.Text = "";
                        calorieTextbox.Text = "";
                        fatTextbox.Text = "";
                        quantityTextbox.Text = "";
                        carbTextBox.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
            }
        }

        private void proteinTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allowing only numbers and dot
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            //if its not a digit and not a dot then handle the process. 
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(proteinTextbox.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void carbTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allowing only numbers and dot
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            //if its not a digit and not a dot then handle the process. 
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(carbTextBox.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void fatTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allowing only numbers and dot
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            //if its not a digit and not a dot then handle the process. 
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(fatTextbox.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void calorieTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void quantityTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows letters and space
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (' ');

        }

    }
}
