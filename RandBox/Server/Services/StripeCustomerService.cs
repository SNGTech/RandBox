using RandBox.Server.Models;
using RandBox.Server.Services.Contracts;
using Stripe;

namespace RandBox.Server.Services
{
    public class StripeCustomerService : IStripeCustomerService
    {
        public StripeCustomerService() { }

        public async Task CreateCustomerAsync(ApplicationUser user)
        {
            var service = new CustomerService();

            var options = new CustomerCreateOptions
            {
                Name = user.FirstName + " " + user.LastName,
                Email = user.Email,
                Address = new AddressOptions
                {
                    Line1 = user.Address + ", Unit #" + user.UnitNo,
                    PostalCode = user.PostalCode,
                }
            };

            await service.CreateAsync(options);
        }
    }
}
