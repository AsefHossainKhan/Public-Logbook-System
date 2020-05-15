using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Public_Pricing_Logbook
{
    public partial class RegistrationPage : Form
    {
        LoginPage login_page = new LoginPage();
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void male_RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void register_Button_Click(object sender, EventArgs e)
        {
            if (username_TextBox.Text == "")
                message_Box("username");
            else if (password_TextBox.Text == "")
                message_Box("password");
            else if (confirmpasssword_TextBox.Text == "")
                message_Box("confirm password");
            else if (fullname_TextBox.Text == "")
                message_Box("full name");
            else if (male_RadioButton.Checked == false && female_RadioButton.Checked == false)
                message_Box("gender");
            else if (securityquestion_ComboBox.Text == "")
                message_Box("security question");
            else if (securityanswer_TextBox.Text == "")
                message_Box("security answer");
            else if (password_TextBox.Text != confirmpasssword_TextBox.Text)
                MessageBox.Show("Passwords don't match", "Error Message!");

            else
            {
                DataTable dt = DataAccess.LoadData($"SELECT * FROM [PublicPricing].[dbo].[Usercredential] WHERE Username = '{username_TextBox.Text}'");
                if (dt.Rows.Count >= 1)
                    MessageBox.Show("Username Already Exists", "Error Message");
                else
                {
                    string gender;
                    if (male_RadioButton.Checked == true)
                        gender = "Male";
                    else
                        gender = "Female";
                    String query = $"INSERT INTO [PublicPricing].[dbo].[Usercredential] (username,password,fullname,gender,securityquestion,securityanswer) VALUES ('{username_TextBox.Text}', '{password_TextBox.Text}', '{fullname_TextBox.Text}', '{gender}', '{securityquestion_ComboBox.Text}', '{securityanswer_TextBox.Text}')";
                    DataAccess.InsertQuery(query);
                    MessageBox.Show("Registration Complete", "System Message");
                    login_page.Show();
                    this.Hide();
                }

            }
        }

        private void message_Box(string message)
        {
            MessageBox.Show($"Enter {message}", "Incomplete Field");
        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            login_page.Show();
            this.Hide();
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {

        }
    }
}
