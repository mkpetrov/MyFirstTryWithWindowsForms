namespace CarsPartsShop
{
    public class ManufacturerCompany
    {
        public ManufacturerCompany(string brand, string country, string address, string phoneNumber)
        {
            this.Brand = brand;
            this.Country = country;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public string Brand { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}