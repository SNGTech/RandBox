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

        /*public Task<SubscriptionCategory> DeleteById(int id)
        {
            throw new NotImplementedException();
        }*/

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

        public async Task<List<SubscriptionCategory>> AddByDuration(int duration, List<SubscriptionCategory> newSubscriptionCategories)
        {
            try
            {
                var response = await _httpClient_Public.PostAsJsonAsync("api/SubscriptionCategory/duration", newSubscriptionCategories);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<SubscriptionCategory>>();
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

        public async Task<List<SubscriptionCategory>> AddByProductCategoryId(int categoryId)
        {
            try
            {
                // No need body content since added SubscriptionCategories are constructed in the controller itself
                var response = await _httpClient_Public.PostAsync($"api/SubscriptionCategory/category/{categoryId}", null);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<SubscriptionCategory>>();
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

        public async Task<List<SubscriptionCategory>> Update(int duration, List<SubscriptionCategory> newSubscriptionCategories)
        {
            try
            {
                var response = await _httpClient_Public.PutAsJsonAsync($"api/SubscriptionCategory/duration/{duration}", newSubscriptionCategories);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<SubscriptionCategory>>();
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

        public async Task<string> DeleteByDuration(int duration)
        {
            try
            {
                var response = await _httpClient_Public.DeleteAsync($"api/SubscriptionCategory/duration/{duration}");

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

        public async Task<string> DeleteByCategoryId(int categoryId)
        {
            try
            {
                var response = await _httpClient_Public.DeleteAsync($"api/SubscriptionCategory/category/{categoryId}");

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
    }
}
