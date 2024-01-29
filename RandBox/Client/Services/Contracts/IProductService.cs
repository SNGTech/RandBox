using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface IProductService : IGenericService<Product>
    {
        public Task<List<Product>> UpdateCategoryToNullOnProduct(Category entity);
        public Task<List<Product>> UpdateCountryToNullOnProduct(Country entity);
        public Task<string> DisableProductById(int id);

        public Task<bool> IsProductReferenced(int productId);


    }
}
