﻿using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface IOrderItemService : IGenericService<OrderItem>
    {
        public Task<List<OrderItem>> GetItemsByOrderId(int orderId);
        public Task<List<OrderItem>> InsertRange(List<OrderItem> newItems);
    }
}
