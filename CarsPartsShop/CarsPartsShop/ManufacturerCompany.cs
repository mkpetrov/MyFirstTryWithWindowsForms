namespace CarsPartsShop
{
    public class ManufacturerCompany
    {
        private string brand;
        private string country;
        private string address;
        private string phoneNumber;

        public ManufacturerCompany(string brand, string country, string address, string phoneNumber)
        {
            this.Brand = brand;
            this.Country = country;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public string Brand { get; private set; }
        public string Country { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }
    }
}