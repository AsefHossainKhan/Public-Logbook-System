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
    public partial class GuestProduct : Form
    {
        String display_query;
        String product_name;
        public GuestProduct()
        {
            InitializeComponent();
        }

        public GuestProduct(String product_name)
        {
            InitializeComponent();

            this.product_name = product_name;

            product_Label.Text = product_name;

            this.display_query = $"SELECT Username,Price,Location,Date FROM [PublicPricing].[dbo].[{product_name}]";
            product_DataGridView.DataSource = DataAccess.LoadData(display_query);
            product_DataGridView.Refresh();
            product_DataGridView.ClearSelection();
        }

        private void GuestProduct_Load(object sender, EventArgs e)
        {

        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            new GuestProductListing().Show();
        }

        private void product_Label_Click(object sender, EventArgs e)
        {

        }

        private void product_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Button_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Close();
            //new GuestProductListing().Show();
        }
    }
}
