using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
	public interface ICartService
	{
		Task<List<OrderItem>> GetAll();
		Task Insert(OrderItem item);
		Task RemoveItem(OrderItem item);
		Task RemoveAll();
		Task UpdateQty(int itemId, int qty);
		decimal GetSubtotalPrice();
		decimal GetTotalPrice();
		decimal GetDiscountedPrice();
	}
}
