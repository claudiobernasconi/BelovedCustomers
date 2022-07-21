namespace BelovedCustomers.Services
{
    public class PremiumCustomerAddressService : IAddressService
    {
        public Address GetAddress(int customerId)
        {
            return new PremiumCustomerAddress("Downtown", "10147", "New Jersey", "United States of America", "+1123487958");
        }
    }

    public class PremiumCustomerAddress : Address
    {
        public PremiumCustomerAddress(string street, string zip, string state, string country, string phone) : base(street, zip, state, country)
        {
            Phone = phone;
        }

        public string Phone { get; set; }
    }
}
