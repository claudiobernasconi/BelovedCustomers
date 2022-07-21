namespace BelovedCustomers.Services
{
    public class DefaultAddressService : IAddressService
    {
        public Address GetAddress(int customerId)
        {
            return new Address("Mainstreet", "10005", "New York", "United States of America");
        }
    }
}
