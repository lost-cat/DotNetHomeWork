using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWorkWebAPI.data;
using HomeWorkWebAPI.entities;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkWebAPI.services
{
    public class DetailRepository : IDetailRepository
    {
        private readonly OrderContext context;

        public DetailRepository(OrderContext context)
        {
            this.context = context;
        }

        public async Task<List<OrderDetail>> GetDetails(Guid id)
        {
            return await context.Details.Where(d => d.OrderId == id)
                .ToListAsync();
        }

        public void AddDetail(Guid orderId, OrderDetail detail)
        {
            detail.OrderId = orderId;
            context.Details.Add(detail);
        }

        public void DeleteDetail(Guid orderId, OrderDetail detail)
        {
            
        }
    }
}