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
    public partial class AddCarForm : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataAdapter da;

        public AddCarForm()
        {
            InitializeComponent();
        }

        private void insertButtonCars_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(@"Data Source=PETROV;Initial Catalog=CarsPartsShop;Integrated Security=True");
            con.Open();
            var cmd = new SqlCommand(@"INSERT INTO Cars (Brand,Model,YearOfManufacture) VALUES (@Brand,@Model,@YearOfManufacture)", con);
            cmd.Parameters.AddWithValue("@Brand", BrandTextBox.Text);
            cmd.Parameters.AddWithValue("@Model", modelTextBox.Text);
            cmd.Parameters.AddWithValue("@YearOfManufacture", yearOfManufacturTextBox.Text);
            cmd.ExecuteNonQuery();

            this.Close();
        }
    }
}
