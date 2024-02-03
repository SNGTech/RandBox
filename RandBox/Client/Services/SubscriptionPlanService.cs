using Microsoft.AspNetCore.Components;
using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    public class SubscriptionPlanService : ISubscriptionPlanService
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        [Inject]
        public HttpInterceptorService _httpInterceptorService { get; set; }

        public SubscriptionPlanService(IHttpClientFactory clientFactory, HttpInterceptorService interceptorService)
        {
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");

            _httpInterceptorService = interceptorService;
        }

        public async Task<string> DeleteById(int id)
        {
            try
            {
                var response = await _httpClient_Public.DeleteAsync($"api/SubscriptionPlan/{id}");

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

        public async Task<SubscriptionPlan> GetById(int id)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/SubscriptionPlan/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<SubscriptionPlan>();
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

        public async Task<SubscriptionPlan> Insert(SubscriptionPlan entity)
        {
            try
            {
                var response = await _httpClient_Public.PostAsJsonAsync("api/SubscriptionPlan", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<SubscriptionPlan>();
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

        public async Task<SubscriptionPlan> Update(SubscriptionPlan entity)
        {
            try
            {
                var response = await _httpClient_Public.PutAsJsonAsync($"api/SubscriptionPlan/{entity.SubscriptionPlanID}", entity);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<SubscriptionPlan>();
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

        public async Task<List<SubscriptionPlan>> UpdateStaffToNullOnSubscriptionPlan(Staff entity)
        {
            try
            {
                var response = await _httpClient_Public.PutAsJsonAsync($"api/SubscriptionPlan/safe-delete/{entity.StaffID}", entity);

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
        public void Dispose() => _httpInterceptorService.DisposeEvent();

        public async Task<List<SubscriptionPlan>> GetSubscriptionsByEmail(string email)
        {
            try
            {
                var response = await _httpClient_Public.GetAsync($"api/SubscriptionPlan/{email}");

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
    }
}
