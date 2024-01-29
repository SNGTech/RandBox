using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface ISubscriptionCategoryService
    {
		public HttpInterceptorService _httpInterceptorService { get; set; }

		public Task<List<SubscriptionCategory>> GetAll();
        public Task<List<SubscriptionCategory>> GetAllBaseCategory();
        public Task<List<SubscriptionCategory>> GetAllByProductCategoryId(int categoryId);
        public Task<List<SubscriptionCategory>> GetAllByDuration(int duration);
        public Task<List<SubscriptionCategory>> AddByDuration(int duration, List<SubscriptionCategory> newSubscriptionCategories);
        public Task<List<SubscriptionCategory>> AddByProductCategoryId(int categoryId);
        public Task<List<SubscriptionCategory>> Update(int duration, List<SubscriptionCategory> newSubscriptionCategories);
        public Task<string> DeleteByDuration(int duration);
        public Task<string> DeleteByCategoryId(int categoryId);
        public Task<List<SubscriptionCategory>> UpdateCategoryToNullOnSubscriptionCategory(Category entity);

    }
}
