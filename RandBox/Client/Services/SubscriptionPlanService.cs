using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class SubscriptionPlanService : IGenericService<SubscriptionPlan>
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        public SubscriptionPlanService(IHttpClientFactory clientFactory)
        {
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");
        }

        public Task<string> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SubscriptionPlan>> GetAll()
        {
            try
            {
                var response = await _httpClient_Public.GetAsync("api/SubscriptionPlan");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<SubscriptionPlan>>();
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

        public Task<SubscriptionPlan> GetByOrderId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SubscriptionPlan> Insert(SubscriptionPlan entity)
        {
            throw new NotImplementedException();
        }

        public Task<SubscriptionPlan> Update(SubscriptionPlan entity)
        {
            throw new NotImplementedException();
        }
    }
}
