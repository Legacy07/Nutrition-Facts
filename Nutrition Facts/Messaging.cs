using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace Nutrition_Facts
{
    public partial class Messaging : Form
    {
        public Messaging()
        {
            InitializeComponent();
        }
        //Not going to work because WART v 3.0 is a paid program, $300
        private void sendButton_Click(object sender, EventArgs e)
        { 
            //Register with WART and use that password given to send messages. 

            WhatsApp wapp = new WhatsApp(numberTextbox.Text, passwordTextbox.Text, nameTextbox.Text, true);
            wapp.OnConnectSuccess += () =>
            {
                eventLogTextbox.Text = "Connected!";
                wapp.OnLoginSuccess += (phoneNumber, data) =>
                {
                    eventLogTextbox.Text = "\r\nLogin Successfull!";
                    wapp.SendMessage(toNumberTextbox.Text, textTextbox.Text);
                    eventLogTextbox.Text = "\r\nMessage sent!";
                };
                wapp.OnLoginFailed += (data) =>
                {
                    eventLogTextbox.Text = string.Format("\r\n Login Failed {0}", data);
                };
                wapp.Login();
            };
            wapp.OnConnectFailed += (ex) =>
            {
                eventLogTextbox.Text += string.Format("\r\nConnect Failed {0}", ex.StackTrace);
            };
            wapp.Connect();
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            if (toTextbox.Text == "" || fromTextbox.Text == "" || passwordEmailTextbox.Text == "" || bodyTextBox.Text == "")
            {
                MessageBox.Show("One of the field is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //hotmail connection
                    SmtpClient email = new SmtpClient("smtp.live.com", 25);
                    MailMessage message = new MailMessage(); // Email Object 
                    email.UseDefaultCredentials = false;
                    email.EnableSsl = true; // Enabling secured Connection using SSL
                    message.From = new MailAddress(fromTextbox.Text); // Sender Email
                    message.To.Add(toTextbox.Text); // Receiver email
                    message.Body = bodyTextBox.Text; // Body of the email
                    message.Subject = subjectTextbox.Text; // Subject of the email

                    if (attachTextbox.Text != null)
                    {
                        message.Attachments.Add(new Attachment(attachTextbox.Text)); //Adding attachment
                    }
                    else
                    {
                    }
                    email.Credentials = new System.Net.NetworkCredential(fromTextbox.Text, passwordEmailTextbox.Text); // Setting Credential of the account
                                                                                                                       // Cursor.Current = Cursors.WaitCursor;
                    email.Send(message); //Sending Email
                    MessageBox.Show("Email Sent!");
                    Cursor.Current = Cursors.Default;
                    message = null; // Free the memory
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            //Getting the Attachment File
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                attachTextbox.Text = openFileDialog.FileName.ToString();
            }
        }
    }

}
