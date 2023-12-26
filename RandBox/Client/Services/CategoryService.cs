using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
	public class CategoryService : IGenericService<Category>
	{
		private readonly HttpClient _httpClient_Public;
		private readonly HttpClient _httpClient_Private;

		public CategoryService(IHttpClientFactory clientFactory) 
		{
			_httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
			_httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");
		}

		public async Task<Category> DeleteById(int id)
		{
			throw new NotImplementedException();
		}

		// Can be accessed Anonymously
		public async Task<List<Category>> GetAll()
		{
			try
			{
				var response = await _httpClient_Public.GetAsync("api/Category");

				if (response.IsSuccessStatusCode)
				{
					if (response.StatusCode == HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<Category>().ToList();
					}
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
			throw new NotImplementedException();
		}

		public async Task<Category> Update(Category entity)
		{
			throw new NotImplementedException();
		}
	}
}
