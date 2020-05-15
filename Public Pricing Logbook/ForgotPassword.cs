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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData($"SELECT * FROM [PublicPricing].[dbo].[Usercredential] WHERE Username = '{enterusername_TextBox.Text}'");
            if (dt.Rows.Count <= 0)
                MessageBox.Show("Username Does Not Exist", "Error Message");
            else
            {
                ResetPassword rp = new ResetPassword(enterusername_TextBox.Text);
                rp.Show();
                this.Hide();
            }
        }
        private void back_Button_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

    }
}
