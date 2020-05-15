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
    public partial class LoginPage : Form
    {
        //string username;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showpassword_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(showpassword_CheckBox.Checked)
            {
                password_TextBox.UseSystemPasswordChar = false;
            }
            else
            {
                password_TextBox.UseSystemPasswordChar = true;
            }
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData($"SELECT * FROM [PublicPricing].[dbo].[Usercredential] WHERE Username = '{username_TextBox.Text}'");
            if (username_TextBox.Text == "")
                MessageBox.Show("Enter Username", "Error Message");
            else if (password_TextBox.Text == "")
                MessageBox.Show("Enter Password", "Error Message");
            else if (dt.Rows.Count <= 0)
                MessageBox.Show("Username Does Not Exist", "Error Message");
            else
            {
                DataTable dt1 = DataAccess.LoadData($"SELECT * FROM [PublicPricing].[dbo].[Usercredential] WHERE Username = '{username_TextBox.Text}' AND Password = '{password_TextBox.Text}'");
                if (dt1.Rows.Count <= 0)
                    MessageBox.Show("Username and Password doesn't match", "Error Message");
                else
                {
                    ModProductListing mdl = new ModProductListing(username_TextBox.Text);
                    //MessageBox.Show("Login Successful");
                    mdl.Show();
                    this.Hide();
                }
            }

        }

        private void register_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrationPage().Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void LoginPage_Enter(object sender, EventArgs e)
        {

        }

        private void loginasguest_Button_Click(object sender, EventArgs e)
        {
            GuestProductListing gpl = new GuestProductListing();
            gpl.Show();
            this.Hide();
        }

        private void forgotpassword_Button_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
            this.Hide();
        }
    }
}
