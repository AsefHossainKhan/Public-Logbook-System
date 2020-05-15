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
    public partial class GuestProductListing : Form
    {
        String product_name;
        GuestProduct guestp;
        String display_query = "SELECT name_of_product 'Product Names' FROM [PublicPricing].[dbo].[productlisting]";
        public GuestProductListing()
        {
            InitializeComponent();

            productlisting_DataGridView.DataSource = DataAccess.LoadData(display_query);
            productlisting_DataGridView.Refresh();
            productlisting_DataGridView.ClearSelection();
        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productlisting_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                productlisting_DataGridView.CurrentRow.Selected = true;
                product_name = productlisting_DataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                guestp = new GuestProduct(product_name);
                guestp.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
