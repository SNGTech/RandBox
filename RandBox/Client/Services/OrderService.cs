using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class OrderService : IGenericService<Orders>
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        public OrderService(IHttpClientFactory clientFactory)
        {
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");
        }

        public async Task<Orders> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        // Can be accessed Anonymously
        public async Task<List<Orders>> GetAll()
        {
            try
            {
                var response = await _httpClient_Public.GetAsync("api/Order");

                if (response.IsSuccessStatusCode)
                {
                    /*if (response.StatusCode == HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<Order>().ToList();
					}*/
                    return await response.Content.ReadFromJsonAsync<List<Orders>>();
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

        public async Task<Orders> GetById(int id)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/Order/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Orders>();
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

        public async Task<Orders> Insert(Orders entity)
        {
            try
            {
                var response = await _httpClient_Public.PostAsJsonAsync("api/Order", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Orders>();
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

        public async Task<Orders> Update(Orders entity)
        {
            try
            {
                var response = await _httpClient_Public.PutAsJsonAsync($"api/Order/{entity.OrderID}", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Orders>();
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

        Task<string> IGenericService<Orders>.DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
