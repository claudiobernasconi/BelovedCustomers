using BelovedCustomers.Services;
using Microsoft.AspNetCore.Mvc;

namespace BelovedCustomers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public Address Get(int customerId)
        {
            return _addressService.GetAddress(customerId);
        }
    }
}