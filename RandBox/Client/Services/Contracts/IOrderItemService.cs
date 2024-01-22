using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface IOrderItemService
    {
		public HttpInterceptorService _httpInterceptorService { get; set; }

		Task<List<OrderItem>> GetAllByOrder(int orderId);
        Task<OrderItem> GetById(int id);
        Task<List<OrderItem>> InsertRange(List<OrderItem> newItems);
        Task<OrderItem> Update(OrderItem updatedItem);
        Task<string> DeleteById(int id);
        Task<List<OrderItem>> GetAll();
        Task<OrderItem> Insert(OrderItem entity);
    }
}
