using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CarPartsShopGui
{
    public partial class AddProductForm : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataAdapter da;

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(@"Data Source=PETROV;Initial Catalog=CarsPartsShop;Integrated Security=True");
            con.Open();
            var cmd = new SqlCommand(@"INSERT INTO Products (Name,Category,PurchasePrice,SellPrice) VALUES (@Name,@Category,@PurchasePrice,@SellPrice)", con);
            cmd.Parameters.AddWithValue("@Name", NameTextBox.Text);
            cmd.Parameters.AddWithValue("@Category", CategoryTextBox.Text);
            cmd.Parameters.AddWithValue("@PurchasePrice",PurchTextBox.Text);
            cmd.Parameters.AddWithValue("@SellPrice", SellPriceTextBox.Text);
            cmd.ExecuteNonQuery();

            this.Close();
        }
    }
}
