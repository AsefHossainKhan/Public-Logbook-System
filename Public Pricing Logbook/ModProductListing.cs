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
    public partial class ModProductListing : Form
    {
        String display_query = "SELECT name_of_product 'Product Names' FROM [PublicPricing].[dbo].[productlisting]";
        String username;
        public ModProductListing()
        {
            InitializeComponent();
        }

        public ModProductListing(string username)
        {
            InitializeComponent();
            this.username = username;

            productlisting_DataGridView.DataSource = DataAccess.LoadData(display_query);
            productlisting_DataGridView.Refresh();
            productlisting_DataGridView.ClearSelection();
        }

        private void ModProductListing_Load(object sender, EventArgs e)
        {

        }

        private void addnewitem_Label_Click(object sender, EventArgs e)
        {

        }

        private void addnewitem_Button_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData($"SELECT * FROM [PublicPricing].[dbo].[productlisting] WHERE name_of_product = '{addnewitem_TextBox.Text}'");
            if(addnewitem_TextBox.Text == "")
            {
                MessageBox.Show("Please Enter a Product Name", "Empty Field");
            }
            else if (dt.Rows.Count >= 1)
                MessageBox.Show("Product Already Exists", "Error Message");
            else
            {
                DataAccess.CreateQuery($"CREATE TABLE {addnewitem_TextBox.Text} (id int NOT NULL IDENTITY(1,1),Username varchar(50) NOT NULL,Price int NOT NULL,Location varchar(50) NOT NULL,Date date NOT NULL,PRIMARY KEY(id) )");
                //MessageBox.Show("Table Created");

                String query = $"INSERT INTO [PublicPricing].[dbo].[productlisting] (name_of_product) VALUES ('{addnewitem_TextBox.Text}')";
                DataAccess.InsertQuery(query);

                productlisting_DataGridView.DataSource = DataAccess.LoadData(display_query);
                productlisting_DataGridView.Refresh();
                productlisting_DataGridView.ClearSelection();
            }
            
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }

        private void productlisting_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                productlisting_DataGridView.CurrentRow.Selected = true;
                String product_name = productlisting_DataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                new ModProduct(username,product_name).Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
