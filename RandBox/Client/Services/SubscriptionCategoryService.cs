using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class SubscriptionCategoryService : ISubscriptionCategoryService
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        public SubscriptionCategoryService(IHttpClientFactory clientFactory)
        {
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");
        }

        public Task<SubscriptionCategory> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SubscriptionCategory>> GetAll()
        {
            try
            {
                var response = await _httpClient_Public.GetAsync("api/SubscriptionCategory");
                if (response.IsSuccessStatusCode)
                {
                    /*if (response.StatusCode == HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<SubscriptionCategory>().ToList();
                    }*/
                    return await response.Content.ReadFromJsonAsync<List<SubscriptionCategory>>();
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

        public async Task<List<SubscriptionCategory>> GetAllBaseCategory()
        {
            try
            {
                var response = await _httpClient_Public.GetAsync("api/SubscriptionCategory/base");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<SubscriptionCategory>>();
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

        public async Task<List<SubscriptionCategory>> GetAllByDuration(int duration)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/SubscriptionCategory/duration/{duration}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<SubscriptionCategory>>();
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

        public async Task<List<SubscriptionCategory>> GetAllByProductCategoryId(int categoryId)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/SubscriptionCategory/category/{categoryId}");
                if (response.IsSuccessStatusCode)
                {
                    /*if (response.StatusCode == HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<SubscriptionCategory>().ToList();
                    }*/
                    return await response.Content.ReadFromJsonAsync<List<SubscriptionCategory>>();
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

        public Task<SubscriptionCategory> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SubscriptionCategory> Insert(SubscriptionCategory entity)
        {
            throw new NotImplementedException();
        }

        public Task<SubscriptionCategory> Update(SubscriptionCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
