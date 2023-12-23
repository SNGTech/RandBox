using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface ICustomerService : IGenericService<Customer>
    {
        public Task<string> GetCurrentCustomerEmail();
    }
}
