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
    public partial class ModProduct : Form
    {
        String display_query;
        String product_name;
        String username;
        public ModProduct()
        {
            InitializeComponent();
        }
        public ModProduct(string username, string product_name)
        {
            InitializeComponent();

            this.product_name = product_name;
            this.username = username;
            
            product_Label.Text = product_name;

            this.display_query = $"SELECT Username,Price,Location,Date FROM [PublicPricing].[dbo].[{product_name}]";
            product_DataGridView.DataSource = DataAccess.LoadData(display_query);
            product_DataGridView.Refresh();
            product_DataGridView.ClearSelection();
        }

        private void ModProduct_Load(object sender, EventArgs e)
        {

        }

        private void product_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool checkIfNumberOnly(string text)
        {
            int counter = 0;

            for (int i=0; i!=text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9' || text[i] == '.') { }
                else
                    counter++;
            }
            if (counter > 0)
                return true;
            return false;
        }

        private void addentry_Button_Click(object sender, EventArgs e)
        {
            if (price_TextBox.Text == "")
                MessageBox.Show("Enter Price", "Empty Field");
            else if (location_TextBox.Text == "")
                MessageBox.Show("Enter Location", "Empty Field");
            else if (checkIfNumberOnly(price_TextBox.Text))
            {
                MessageBox.Show("Enter Valid Price", "Wrong Input");
            }
            else
            {
                String query = $"INSERT INTO [PublicPricing].[dbo].[{product_name}] (username,price,location,date) VALUES ('{this.username}',{price_TextBox.Text},'{location_TextBox.Text}','{product_DateTimePicker.Value}')";
                DataAccess.InsertQuery(query);

                product_DataGridView.DataSource = DataAccess.LoadData(display_query);
                product_DataGridView.Refresh();
                product_DataGridView.ClearSelection();
            }
        }

        private void back_Button_Click(object sender, EventArgs e)
        {
            ModProductListing mdl = new ModProductListing(this.username);
            mdl.Show();
            this.Hide();
        }

        private void deleteproduct_Button_Click(object sender, EventArgs e)
        {
            String del_query = $"DROP TABLE {product_name}";
            DataAccess.DeleteQuery(del_query);
            MessageBox.Show("Product Deleted", "Info");
            String remove_query = $"DELETE FROM productlisting WHERE name_of_product ='{product_name}';";
            DataAccess.DeleteQuery(remove_query);
            ModProductListing mdl = new ModProductListing(this.username);
            mdl.Show();
            this.Hide();
        }

        private void product_Label_Click(object sender, EventArgs e)
        {

        }

        private void price_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
