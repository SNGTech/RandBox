using Microsoft.AspNetCore.Components;
using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        [Inject]
        public HttpInterceptorService _httpInterceptorService { get; set; }

        public CustomerService(IHttpClientFactory clientFactory, HttpInterceptorService interceptorService)
        {
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");

            _httpInterceptorService = interceptorService;
        }

        public async Task<string> DeleteById(int id)
        {
            try
            {
                var response = await _httpClient_Public.DeleteAsync($"api/Customer/{id}");

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

        public async Task<List<Customer>> GetAll()
        {
            try
            {
                var response = await _httpClient_Public.GetAsync("api/Customer");

                if (response.IsSuccessStatusCode)
                {
                    /*if (response.StatusCode == HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<Country>().ToList();
					}*/
                    return await response.Content.ReadFromJsonAsync<List<Customer>>();
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

        public async Task<Customer> GetById(int id)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/Customer/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Customer>();
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

        public async Task<Customer> Insert(Customer entity)
        {
            try
            {
                var response = await _httpClient_Public.PostAsJsonAsync("api/Customer", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Customer>();
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

        public async Task<Customer> Update(Customer entity)
        {
            try
            {
                var response = await _httpClient_Public.PutAsJsonAsync($"api/Customer/{entity.CustID}", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Customer>();
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

        public void Dispose() => _httpInterceptorService.DisposeEvent();

        public async Task<bool> IsCustomerReferenced(int customerId)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/Customer/ReferenceExistInAnyEntity/{customerId}");

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<bool>();
                    return result;
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
