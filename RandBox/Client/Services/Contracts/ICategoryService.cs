using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface ICategoryService : IGenericService<Category>
    {
        public Task<string> DisableCategoryById(int id);
    }
}
