using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Client.Services
{
    public class CartService : ICartService
	{
		[Inject]
		public ILocalStorageService _localStorage { get; set; }

		private List<OrderItem> cartItems = new List<OrderItem>();

        public CartService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task RemoveItem(OrderItem item)
		{
			cartItems.Remove(item);
			await _localStorage.SetItemAsync("cartItems", cartItems);
		}

		public async Task<List<OrderItem>> GetAll()
		{
			var items = await _localStorage.GetItemAsync<List<OrderItem>>("cartItems");

			if (items == null)
			{
                await _localStorage.SetItemAsync("cartItems", cartItems);
                return cartItems;
			}

			cartItems = items;
            return items;
		}

		public async Task Insert(OrderItem item)
		{
			item.OrderItemID = cartItems.Count == 0 ? 1 : cartItems.Last().OrderItemID + 1;
			cartItems.Add(item);
			await _localStorage.SetItemAsync("cartItems", cartItems);
		}

		public async Task UpdateQty(int itemId, int qty)
		{
			var item = cartItems.FirstOrDefault(x => x.OrderItemID == itemId);
            item!.Qty = qty;
			await _localStorage.SetItemAsync("cartItems", cartItems);
		}

		public async Task RemoveAll()
		{
			cartItems.Clear();
			await _localStorage.SetItemAsync("cartItems", cartItems);
		}

        public decimal GetSubtotalPrice()
        {
			return Math.Round(cartItems.Sum(x => x.Product!.OriginalPrice * x.Qty), 2);
        }

        public decimal GetTotalPrice()
        {
            return Math.Round(cartItems.Sum(x => x.Product!.DiscountedPrice * x.Qty), 2);
        }

        public decimal GetDiscountedPrice()
        {
            return Math.Round(GetSubtotalPrice() - GetTotalPrice(), 2);
        }
    }
}
