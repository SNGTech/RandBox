using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface ISubscriptionItemService
    {
        public Task<List<SubscriptionItem>> GetAllByPlan(int planId);

        public Task<List<SubscriptionItem>> InsertRange(List<SubscriptionItem> newItems);
    }
}
