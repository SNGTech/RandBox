using RandBox.Client.Services.Contracts;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace RandBox.Client.Services
{
    // Should only use private client
    public class PaymentIntentService : IPaymentIntentService
    {
        /*private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        public PaymentIntentService(IHttpClientFactory clientFactory)
        {
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
        }

        public async Task<string> CreatePaymentIntent(int planId, string custEmail)
        {
            try
            {
                var body = new { plan_id = planId, cust_email = custEmail };
                var response = await _httpClient_Public.PostAsJsonAsync("api/payment-intent", body);
                if (response.IsSuccessStatusCode)
                {
                    *//*if (response.StatusCode == HttpStatusCode.NoContent)
                    {
                        return "{}";
                    }*//*
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"HTTP Status: {response.StatusCode} - Message: {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/
    }
}
