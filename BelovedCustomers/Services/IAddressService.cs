namespace BelovedCustomers.Services
{
    public interface IAddressService
    {
        Address GetAddress(int customerId);
    }

    public class Address
    {
        public Address(string street, string zip, string state, string country)
        {
            Street = street;
            Zip = zip;
            State = state;
            Country = country;
        }

        public string Street { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
