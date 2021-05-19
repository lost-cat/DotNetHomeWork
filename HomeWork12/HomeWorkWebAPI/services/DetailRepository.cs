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

        public async Task<List<OrderDetail>> GetDetails(Guid orderId)
        {
            return await context.Details.Where(d => d.OrderId == orderId)
                .ToListAsync();
        }

        public void AddDetail(Guid orderId, OrderDetail detail)
        {
            detail.OrderId = orderId;
            detail.Item.Id = Guid.NewGuid();
            detail.Id = Guid.NewGuid();

            context.Details.Add(detail);
        }

        public async Task<OrderDetail> GetDetail(Guid orderId, Guid detailId)
        {
            return await context.Details.FirstOrDefaultAsync(d => d.Id == detailId && d.OrderId == orderId);
        }

        public void DeleteDetail(Guid orderId, OrderDetail detail)
        {
        }

        public async Task<bool> Save()
        {
            return await context.SaveChangesAsync() > 0;
        }
    }
}