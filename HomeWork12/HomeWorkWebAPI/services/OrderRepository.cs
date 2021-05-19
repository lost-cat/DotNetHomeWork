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
            this.context = context ?? throw  new  ArgumentNullException(nameof(context));
        }

        public async Task<List<Order>> GetOrders()
        {
            return await context.Orders.ToListAsync();
        }

        public async Task<Order> GetOrder(Guid id)
        {
            return await context.Orders
                .Include(o=>o.Customer)
                .Include(o=>o.List)
                    .ThenInclude(o=>o.Item)
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public void AddOrder(Order order)
        {
            order.Id = Guid.NewGuid();
            
            order.Customer.Id=Guid.NewGuid();
            
            if (order.List.Count!=0)
            {
                foreach (var detail in order.List)
                {
                    detail.Id = Guid.NewGuid();
                    detail.Item.Id = Guid.NewGuid();
                }
            }
            context.Add(order);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}