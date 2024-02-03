using RandBox.Shared.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RandBox.Client.Services.Contracts
{
    public interface IOrderService : IGenericService<Orders>
    {
        public Task<List<Orders>> GetOrdersByEmail(string email);
        public Task<decimal> GetTotalIncomeFromOrders();
        public Task<List<Orders>> UpdateStaffToNullOnOrder(Staff entity);
        public Task<Orders> MarkDelivered(int id);
    }
}
