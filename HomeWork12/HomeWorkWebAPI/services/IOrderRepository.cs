using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeWorkWebAPI.entities;

namespace HomeWorkWebAPI.services
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetOrders();
        Task<Order> GetOrder(Guid id);
        void AddOrder(Order order);

        Task<int> SaveChangesAsync();
    }
}