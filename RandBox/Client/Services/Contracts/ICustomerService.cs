﻿// ICustomerService.cs

using RandBox.Shared.Domain;
using System.Threading.Tasks;

namespace RandBox.Client.Services.Contracts
{
    public interface ICustomerService : IGenericService<Customer>
    {
        Task<bool> IsCustomerReferenced(int customerId);
        Task<Customer> GetCurrentCustomer(string email);
        Task<bool> DoesCurrentCustomerExist(string? email);
    }
}
