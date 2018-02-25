using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrition_Facts
{
    public partial class BMRForm : Form
    {
        public BMRForm()
        {
            InitializeComponent();

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(weightLabel, "In kg");
            tooltip.SetToolTip(heightLabel, "In cm");
            tooltip.SetToolTip(ageLabel, "In years");
            standardBMRRadioButton.Checked = true;

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (weightTextBox.Text.Equals("") || heightTextBox.Text.Equals("") || ageTextBox.Text.Equals(""))
            {
                MessageBox.Show("One or more fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (standardBMRRadioButton.Checked)
                {
                    double output = BMREquation(Double.Parse(weightTextBox.Text), Double.Parse(heightTextBox.Text), Double.Parse(ageTextBox.Text));
                    outputLabel.Text = "You have a BMR of " + output.ToString();
                }
                else if (surplusRadioButton.Checked)
                {
                    double firstOutput = BMREquation(Double.Parse(weightTextBox.Text), Double.Parse(heightTextBox.Text), Double.Parse(ageTextBox.Text)) + 250;
                    double secondOutput = BMREquation(Double.Parse(weightTextBox.Text), Double.Parse(heightTextBox.Text), Double.Parse(ageTextBox.Text)) + 500;

                    outputLabel.Text = "Your BMR for a surplus will be between " + Environment.NewLine + firstOutput.ToString() + " - " + secondOutput;
                }
                else if (deficitRadioButton.Checked)
                {
                    double firstOutput = BMREquation(Double.Parse(weightTextBox.Text), Double.Parse(heightTextBox.Text), Double.Parse(ageTextBox.Text)) - 250;
                    double secondOutput = BMREquation(Double.Parse(weightTextBox.Text), Double.Parse(heightTextBox.Text), Double.Parse(ageTextBox.Text)) - 500;

                    outputLabel.Text = "Your BMR for a deficit will be between " + Environment.NewLine + firstOutput.ToString() + " - " + secondOutput;
                }
            }
        }

        public double BMREquation(double weight, double height, double age)
        {
            double answer = 66.47 + (13.47 * weight) + (5 * height) - (6.8 * age);
            return answer;
        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allowing only numbers and dot
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            //if its not a digit and not a dot then handle the process. 
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(weightTextBox.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
