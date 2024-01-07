using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class SubscriptionItemService : ISubscriptionItemService
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        public SubscriptionItemService(IHttpClientFactory clientFactory)
        {
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");
        }

        public async Task<List<SubscriptionItem>> GetAllByPlan(int planId)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/SubscriptionItem/plan/{planId}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<SubscriptionItem>>();
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

        public async Task<List<SubscriptionItem>> InsertRange(List<SubscriptionItem> newItems)
        {
            try
            {
                var response = await _httpClient_Public.PostAsJsonAsync("api/SubscriptionItem", newItems);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<SubscriptionItem>>();
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
