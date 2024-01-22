using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface IOrderService : IGenericService<Orders>
    {
        public Task<decimal> GetTotalIncomeFromOrders();
    }
}
