using Microsoft.AspNetCore.Components;
using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class CategoryService : ICategoryService
	{
		private readonly HttpClient _httpClient_Public;
		private readonly HttpClient _httpClient_Private;

        [Inject]
        public HttpInterceptorService _httpInterceptorService { get; set; }

		public CategoryService(IHttpClientFactory clientFactory, HttpInterceptorService interceptorService) 
		{
			_httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
			_httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");

            _httpInterceptorService = interceptorService;
		}

        public async Task<string> DeleteById(int id)
        {
            try
            {
                var response = await _httpClient_Public.DeleteAsync($"api/Category/{id}");

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
        public async Task<List<Category>> GetAll()
		{
			try
			{
				var response = await _httpClient_Public.GetAsync("api/Category");

				if (response.IsSuccessStatusCode)
				{
					/*if (response.StatusCode == HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<Category>().ToList();
					}*/
					return await response.Content.ReadFromJsonAsync<List<Category>>();
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

        public async Task<Category> GetById(int id)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/Category/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Category>();
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

        public async Task<Category> Insert(Category entity)
		{
            try
            {
                var response = await _httpClient_Public.PostAsJsonAsync("api/Category", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Category>();
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

		public async Task<Category> Update(Category entity)
		{
			try
			{
				var response = await _httpClient_Public.PutAsJsonAsync($"api/Category/{entity.CategoryID}", entity);

				if (response.IsSuccessStatusCode)
				{
					return await response.Content.ReadFromJsonAsync<Category>();
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

        public async Task<bool> IsCategoryReferenced(int categoryId)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/Category/ReferenceExistInAnyEntity/{categoryId}");

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
