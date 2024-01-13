using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class ProductService : IGenericService<Product>
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        public ProductService(IHttpClientFactory clientFactory)
        {
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");
        }

        public async Task<string> DeleteById(int id)
        {
            try
            {
                var response = await _httpClient_Public.DeleteAsync($"api/Product/{id}");

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

        // Can be accessed Anonymously
        public async Task<List<Product>> GetAll()
        {
            try
            {
                var response = await _httpClient_Public.GetAsync("api/Product");

                if (response.IsSuccessStatusCode)
                {
                    /*if (response.StatusCode == HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<Product>().ToList();
					}*/
                    return await response.Content.ReadFromJsonAsync<List<Product>>();
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

        public async Task<Product> GetByOrderId(int id)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/Product/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Product>();
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

        public async Task<Product> Insert(Product entity)
        {
            try
            {
                var response = await _httpClient_Public.PostAsJsonAsync("api/Product", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Product>();
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

        public async Task<Product> Update(Product entity)
        {
            try
            {
                var response = await _httpClient_Public.PutAsJsonAsync($"api/Product/{entity.ProductID}", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Product>();
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
    }
}
