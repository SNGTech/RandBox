using Microsoft.AspNetCore.Components;
using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class SubscriptionItemService : ISubscriptionItemService
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

		[Inject]
		public HttpInterceptorService _httpInterceptorService { get; set; }

		public SubscriptionItemService(IHttpClientFactory clientFactory, HttpInterceptorService interceptorService)
		{
			_httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
			_httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");

			_httpInterceptorService = interceptorService;
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

        public Task<SubscriptionItem> GetById(int id)
        {
            throw new NotImplementedException();
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

        public async Task<SubscriptionItem> Update(SubscriptionItem updatedItem)
        {
            try
            {
                var response = await _httpClient_Public.PutAsJsonAsync($"api/SubscriptionItem/{updatedItem.SubscriptionItemID}", updatedItem);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<SubscriptionItem>();
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

        public async Task<string> DeleteById(int id)
        {
            try
            {
                var response = await _httpClient_Public.DeleteAsync($"api/SubscriptionItem/{id}");

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

		public void Dispose() => _httpInterceptorService.DisposeEvent();
	}
}
