using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeWorkWebAPI.data;
using HomeWorkWebAPI.entities;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkWebAPI.services
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderContext context;

        public OrderRepository(OrderContext context)
        {
            this.context = context;
        }

        public async Task<List<Order>> GetOrders()
        {
            return await context.Orders.ToListAsync();
        }

        public async Task<Order> GetOrder(Guid id)
        {
            return await context.Orders.FirstOrDefaultAsync(o => o.Id == id);
        }

        public void AddOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            order.Id = Guid.NewGuid();
            context.Add(order);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}