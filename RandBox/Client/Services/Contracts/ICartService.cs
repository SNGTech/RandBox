using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
	public interface ICartService
	{
		Task<List<OrderItem>> GetAll();
		Task Insert(OrderItem item);
		Task<string> DeleteById(int id);
		Task UpdateQty(int qty);
	}
}
