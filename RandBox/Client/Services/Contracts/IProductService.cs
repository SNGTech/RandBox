using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface IProductService : IGenericService<Product>
    {
        public Task<List<Product>> RemoveCountryFromProducts(int countryId);
    }
}
