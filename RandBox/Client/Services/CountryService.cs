using Microsoft.AspNetCore.Components;
using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class CountryService : IGenericService<Country>
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        [Inject]
        public HttpInterceptorService _httpInterceptorService { get; set; }

        public CountryService(IHttpClientFactory clientFactory, HttpInterceptorService interceptorService)
        {
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");

            _httpInterceptorService = interceptorService;
        }

        public async Task<string> DeleteById(int id)
        {
            try
            {
                var response = await _httpClient_Public.DeleteAsync($"api/Country/{id}");

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
        public async Task<List<Country>> GetAll()
        {
            try
            {
                var response = await _httpClient_Public.GetAsync("api/Country");

                if (response.IsSuccessStatusCode)
                {
                    /*if (response.StatusCode == HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<Country>().ToList();
					}*/
                    return await response.Content.ReadFromJsonAsync<List<Country>>();
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

        public async Task<Country> GetById(int id)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/Country/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Country>();
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

        public async Task<Country> Insert(Country entity)
        {
            try
            {
                var response = await _httpClient_Public.PostAsJsonAsync("api/Country", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Country>();
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

        public async Task<Country> Update(Country entity)
        {
            try
            {
                var response = await _httpClient_Public.PutAsJsonAsync($"api/Country/{entity.CountryID}", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Country>();
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
