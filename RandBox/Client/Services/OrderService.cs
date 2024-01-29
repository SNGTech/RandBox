    using Microsoft.AspNetCore.Components;
    using RandBox.Client.Services.Contracts;
    using RandBox.Shared.Domain;
    using System.Net;
    using System.Net.Http.Json;

    namespace RandBox.Client.Services
    {
        public class OrderService : IOrderService
        {
            private readonly HttpClient _httpClient_Public;
            private readonly HttpClient _httpClient_Private;

            [Inject]
            public HttpInterceptorService _httpInterceptorService { get; set; }

            public OrderService(IHttpClientFactory clientFactory, HttpInterceptorService interceptorService)
            {
                _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
                _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");

                _httpInterceptorService = interceptorService;
            }

            public async Task<string> DeleteById(int id)
            {
                try
                {
                    var response = await _httpClient_Public.DeleteAsync($"api/Order/{id}");

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
            public async Task<List<Orders>> GetAll()
            {
                try
                {
                    var response = await _httpClient_Public.GetAsync("api/Order");

                    if (response.IsSuccessStatusCode)
                    {
                        /*if (response.StatusCode == HttpStatusCode.NoContent)
					    {
						    return Enumerable.Empty<Order>().ToList();
					    }*/
                        return await response.Content.ReadFromJsonAsync<List<Orders>>();
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

            public async Task<Orders> GetById(int id)
            {
                try
                {
                    var response = await _httpClient_Public.GetAsync($"api/Order/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<Orders>();
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

            public async Task<Orders> Insert(Orders entity)
            {
                try
                {
                    var response = await _httpClient_Public.PostAsJsonAsync("api/Order", entity);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<Orders>();
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

            public async Task<Orders> Update(Orders entity)
            {
                try
                {
                    var response = await _httpClient_Public.PutAsJsonAsync($"api/Order/{entity.OrderID}", entity);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<Orders>();
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

            public async Task<List<Orders>> UpdateStaffToNullOnOrder(Staff entity)
            {
                try
                {
                    var response = await _httpClient_Public.PutAsJsonAsync($"api/Order/safe-delete/{entity.StaffID}", entity);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<List<Orders>>();
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

            public async Task<decimal> GetTotalIncomeFromOrders()
            {
                try
                {
                    var response = await _httpClient_Public.GetAsync($"api/Order/total");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<decimal>();
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

        public async Task<Orders> MarkDelivered(int id)
        {
            try
            {
                var response = await _httpClient_Public.PutAsync($"api/Order/mark-delivered/{id}", null);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Orders>();
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
