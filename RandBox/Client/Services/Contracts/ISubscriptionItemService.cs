using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface ISubscriptionItemService
    {
        public Task<List<SubscriptionItem>> GetAllByPlan(int planId);
        public Task <SubscriptionItem>GetById(int id);
        public Task<List<SubscriptionItem>> InsertRange(List<SubscriptionItem> newItems);
        public Task<SubscriptionItem> Update(SubscriptionItem updatedItem);
        public Task<string> DeleteById(int id);
    }
}
