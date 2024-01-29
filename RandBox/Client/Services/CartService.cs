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

        public Task<string> DeleteById(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<OrderItem>> GetAll()
		{
			var items = await _localStorage.GetItemAsync<List<OrderItem>>("cartItems");

			if (items == null)
			{
				return cartItems;
			}

			await _localStorage.SetItemAsync("cartItems", cartItems);
			return items;
		}

		public Task Insert(OrderItem item)
		{
			throw new NotImplementedException();
		}

		public Task UpdateQty(int qty)
		{
			throw new NotImplementedException();
		}
	}
}
