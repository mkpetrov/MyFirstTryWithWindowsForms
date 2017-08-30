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
            var carList = new List<Car>();

            var mazda=new Car("6",2003,"Mazda");
            carList.Add(mazda);
            var honda=new Car("Civic",1995,"Honda");
            carList.Add(honda);
            
            var bindingList=new BindingList<Car>(carList);
            var source=new BindingSource(bindingList,null);
            dataGridView1.DataSource = source;
        }

        private void Products_Click(object sender, EventArgs e)
        {
            var productsList=new List<Product>();

            var engine=new Product(532156456,"Peugeot","Parts",155.26,300.00);
            var seat=new Product(56456456,"Corbeau","Interior",123.45,250.00);
            productsList.Add(engine);
            productsList.Add(seat);
            
            var bindingList=new BindingList<Product>(productsList);
            var source=new BindingSource(bindingList,null);
            dataGridView1.DataSource = source;

        }

        private void Companies_Click(object sender, EventArgs e)
        {
            var companiesList=new List<ManufacturerCompany>();

            var brembo=new ManufacturerCompany("Brembo","Italy","Bergamo","+221886565");
            var bmw=new ManufacturerCompany("BMW","Germany","Munich","+44665932887");
            companiesList.Add(brembo);
            companiesList.Add(bmw);

            var bindingList = new BindingList<ManufacturerCompany>(companiesList);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
