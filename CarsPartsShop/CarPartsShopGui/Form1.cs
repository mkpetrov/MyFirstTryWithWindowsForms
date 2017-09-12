using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarsPartsShop;
using System.Data.SqlClient;

namespace CarPartsShopGui
{
    public partial class ShopGui : Form
    {
        public ShopGui()
        {
            InitializeComponent();
        }
        
        private void Cars_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=PETROV;Initial Catalog=CarsPartsShop;Integrated Security=True";
            var conDataBase=new SqlConnection(conString);
            var cmdDataBase=new SqlCommand("SELECT * FROM Cars",conDataBase);
            try
            {
                var sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                var dbDataSet = new DataTable();
                sda.Fill(dbDataSet);
                var bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                dataGridView1.DataSource = bSource;
                sda.Update(dbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Products_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=PETROV;Initial Catalog=CarsPartsShop;Integrated Security=True";
            var conDataBase = new SqlConnection(conString);
            var cmdDataBase = new SqlCommand("SELECT * FROM Products", conDataBase);
            try
            {
                var sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                var dbDataSet = new DataTable();
                sda.Fill(dbDataSet);
                var bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                dataGridView1.DataSource = bSource;
                sda.Update(dbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Companies_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=PETROV;Initial Catalog=CarsPartsShop;Integrated Security=True";
            var conDataBase = new SqlConnection(conString);
            var cmdDataBase = new SqlCommand("SELECT * FROM ManufacturerCompanies", conDataBase);
            try
            {
                var sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                var dbDataSet = new DataTable();
                sda.Fill(dbDataSet);
                var bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                dataGridView1.DataSource = bSource;
                sda.Update(dbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            AddCarForm frm=new AddCarForm();
            frm.Show();
        }

        private void AddCompany_Click(object sender, EventArgs e)
        {
            ManufacturersForm frm=new ManufacturersForm();
            frm.Show();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm frm=new AddProductForm();    
            frm.Show();
        }
    }
}
