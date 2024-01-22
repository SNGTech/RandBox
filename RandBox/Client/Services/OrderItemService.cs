using Microsoft.AspNetCore.Components;
using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

		[Inject]
		public HttpInterceptorService _httpInterceptorService { get; set; }

		public OrderItemService(IHttpClientFactory clientFactory, HttpInterceptorService interceptorService)
		{
			_httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
			_httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");

			_httpInterceptorService = interceptorService;
		}

		public async Task<List<OrderItem>> GetAllByOrder(int orderId)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/OrderItem/order/{orderId}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<OrderItem>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"HTTP Status: {response.StatusCode} - {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<OrderItem>> GetAll()
        {
            try
            {
                var response = await _httpClient_Public.GetAsync("api/OrderItem");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<OrderItem>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"HTTP Status : {response.StatusCode} - {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Task<OrderItem> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<OrderItem> Insert(OrderItem entity)
        {
            try
            {
                var response = await _httpClient_Public.PostAsJsonAsync("api/OrderItem", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<OrderItem>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"HTTP Status : {response.StatusCode} - {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<OrderItem>> InsertRange(List<OrderItem> newItems)
        {
            try
            {
                var response = await _httpClient_Public.PostAsJsonAsync("api/OrderItem", newItems);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<OrderItem>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"HTTP Status : {response.StatusCode} - {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<OrderItem> Update(OrderItem updatedItem)
        {
            try
            {
                var response = await _httpClient_Public.PutAsJsonAsync($"api/OrderItem/{updatedItem.OrderItemID}", updatedItem);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<OrderItem>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"HTTP Status : {response.StatusCode} - {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> DeleteById(int id)
        {
            try
            {
                var response = await _httpClient_Public.DeleteAsync($"api/OrderItem/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"HTTP Status : {response.StatusCode} - {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<List<OrderItem>> GetItemsByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }

		public void Dispose() => _httpInterceptorService.DisposeEvent();
	}
}
