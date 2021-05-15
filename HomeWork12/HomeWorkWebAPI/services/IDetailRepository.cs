using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeWorkWebAPI.entities;

namespace HomeWorkWebAPI.services
{
    public interface IDetailRepository
    {
        Task<List<OrderDetail>> GetDetails(Guid id);
        void AddDetail(Guid orderId, OrderDetail detail);
        void DeleteDetail(Guid orderId, OrderDetail detail);
    }
}