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
    public partial class ManufacturersForm : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataAdapter da;

        public ManufacturersForm()
        {
            InitializeComponent();
        }

        private void insertButtonManufacturers_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(@"Data Source=PETROV;Initial Catalog=CarsPartsShop;Integrated Security=True");
            con.Open();
            var cmd = new SqlCommand(@"INSERT INTO ManufacturerCompanies (Brand,Country,Address,Phone,Fax) VALUES (@Brand,@Country,@Address,@Phone,@Fax)", con);
            cmd.Parameters.AddWithValue("@Brand", brandTextBox.Text);
            cmd.Parameters.AddWithValue("@Country", countryTextBox.Text);
            cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);
            cmd.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
            cmd.Parameters.AddWithValue("@Fax", faxTextBox.Text);
            cmd.ExecuteNonQuery();

            this.Close();
        }
    }
}
