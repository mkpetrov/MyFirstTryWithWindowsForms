using System.Runtime.InteropServices;

namespace CarsPartsShop
{
    public class Product
    {
        private int id;
        private string name;
        private string category;
        private double purchasePrice;
        private double sellPrice;

        public Product(int id,string name,string category,double purchasePrice, double sellPrice)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.PurchasePrice = purchasePrice;
            this.SellPrice = sellPrice;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Category { get; private set; }
        public double PurchasePrice { get; private set; }
        public double SellPrice { get; private set; }

    }
}