using Microsoft.AspNetCore.Components;
using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class StaffService : IGenericService<Staff>
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        [Inject]
        public HttpInterceptorService _httpInterceptorService { get; set; }

        public StaffService(IHttpClientFactory clientFactory, HttpInterceptorService interceptorService)
        {
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");

            _httpInterceptorService = interceptorService;
        }

        public async Task<string> DeleteById(int id)
        {
            try
            {
                var response = await _httpClient_Public.DeleteAsync($"api/Staff/{id}"); // Update the endpoint

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
        public async Task<List<Staff>> GetAll() // Update the return type
        {
            try
            {
                var response = await _httpClient_Public.GetAsync("api/Staff"); // Update the endpoint

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<Staff>>();
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

        public async Task<Staff> GetById(int id)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/Staff/{id}"); // Update the endpoint

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Staff>();
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

        public async Task<Staff> Insert(Staff entity)
        {
            try
            {
                var response = await _httpClient_Public.PostAsJsonAsync("api/Staff", entity); // Update the endpoint

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Staff>();
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

        public async Task<Staff> Update(Staff entity)
        {
            try
            {
                var response = await _httpClient_Public.PutAsJsonAsync($"api/Staff/{entity.StaffID}", entity); // Update the endpoint

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Staff>();
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
	}
}
