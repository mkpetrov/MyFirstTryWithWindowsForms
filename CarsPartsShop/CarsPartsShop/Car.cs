namespace CarsPartsShop
{
    public class Car
    {
        private string model;
        private int yearOfManufacture;
        private string brand;

        public Car(string model, int yearOfManufacture, string brand)
        {
            this.Model = model;
            this.YearOfManufacture = yearOfManufacture;
            this.Brand = brand;
        }

        public string Model { get; set; }
        public int YearOfManufacture { get; set; }
        public string Brand { get; set; }
    }
}