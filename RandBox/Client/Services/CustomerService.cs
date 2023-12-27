﻿using RandBox.Client.Services.Contracts;
using RandBox.Shared.Domain;
using System.Net;
using System.Net.Http.Json;

namespace RandBox.Client.Services
{
    // To use only private client
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient _httpClient_Public;
        private readonly HttpClient _httpClient_Private;

        public CustomerService(IHttpClientFactory clientFactory)
        {
            _httpClient_Public = clientFactory.CreateClient("RandBox.ServerAPI.public");
            _httpClient_Private = clientFactory.CreateClient("RandBox.ServerAPI.private");
        }

        public Task<Customer> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetCurrentCustomerEmail()
        {
            try
            {
                var response = await _httpClient_Public.GetAsync("api/Customer/current");

                if (response.IsSuccessStatusCode)
                {
                    /*if (response.StatusCode == HttpStatusCode.NoContent)
                    {
                        return "";
                    }*/
                    return await response.Content.ReadFromJsonAsync<string>();
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

        public Task<Customer> Insert(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
