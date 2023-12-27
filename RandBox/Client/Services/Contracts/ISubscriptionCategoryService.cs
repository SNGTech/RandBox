using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface ISubscriptionCategoryService : IGenericService<SubscriptionCategory>
    {
        public Task<List<SubscriptionCategory>> GetAllBaseCategory();
        public Task<List<SubscriptionCategory>> GetAllByProductCategoryId(int categoryId);
        public Task<List<SubscriptionCategory>> GetAllByDuration(int duration);
    }
}
