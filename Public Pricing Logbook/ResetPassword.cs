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
    public partial class ResetPassword : Form
    {
        String username;
        public ResetPassword()
        {
            InitializeComponent();
        }

        public ResetPassword(String username)
        {
            InitializeComponent();
            this.username = username;

            DataTable dt = DataAccess.LoadData($"SELECT * FROM [PublicPricing].[dbo].[Usercredential] WHERE Username = '{username}'");
            securityquestion_Label.Text = dt.Rows[0]["securityquestion"].ToString();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void confirm_Button_Click(object sender, EventArgs e)
        {
            DataTable dt1 = DataAccess.LoadData($"SELECT * FROM [PublicPricing].[dbo].[Usercredential] WHERE Username = '{username}' AND securityanswer = '{answer_TextBox.Text}'");
            if (answer_TextBox.Text == "")
                MessageBox.Show("Enter Answer", "Empty Field");
            else if (newpassword_TextBox.Text == "")
                MessageBox.Show("Enter Password", "Empty Field");
            else if (confirmpassword_TextBox.Text == "")
                MessageBox.Show("Enter Confirm Password", "Empty Field");
            else if (dt1.Rows.Count <= 0)
                MessageBox.Show("Security answer isn't correct", "Error Message");
            else
            {
                if (newpassword_TextBox.Text != confirmpassword_TextBox.Text)
                    MessageBox.Show("Passwords don't match", "Error Message");
                else
                {
                    String update_query = $"UPDATE [PublicPricing].[dbo].[Usercredential] SET password = '{newpassword_TextBox.Text}' WHERE username = {username}";
                    MessageBox.Show("Password updated", "Confirmation");
                    new LoginPage().Show();
                    this.Hide();
                }
            }
        }

        private void home_Button_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }
    }
}
