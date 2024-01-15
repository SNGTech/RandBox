using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        public OrderItemService(IHttpClientFactory clientFactory)
        {
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");
        }

        public async Task<OrderItem> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        // Can be accessed Anonymously
        public async Task<List<OrderItem>> GetAll()
        {
            try
            {
                var response = await _httpClient_Public.GetAsync("api/OrderItem");

                if (response.IsSuccessStatusCode)
                {
                    /*if (response.StatusCode == HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<OrderItem>().ToList();
					}*/
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

        public async Task<List<OrderItem>> GetItemsByOrderId(int orderId)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/OrderItems?orderId={orderId}");

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

        public async Task<OrderItem> Update(OrderItem entity)
        {
            try
            {
                var response = await _httpClient_Public.PutAsJsonAsync($"api/OrderItem/{entity.OrderItemID}", entity);

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

        Task<string> IGenericService<OrderItem>.DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
