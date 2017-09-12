using System.Runtime.InteropServices;

namespace CarsPartsShop
{
    public class Product
    {

        public Product(int id, string name, string category, double purchasePrice, double sellPrice)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.PurchasePrice = purchasePrice;
            this.SellPrice = sellPrice;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double PurchasePrice { get; set; }
        public double SellPrice { get; set; }

    }
}