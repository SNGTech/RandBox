using RandBox.Shared.Domain;

namespace RandBox.Server.Repositories.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task RemoveCountryInProducts(int countryId);
    }
}
