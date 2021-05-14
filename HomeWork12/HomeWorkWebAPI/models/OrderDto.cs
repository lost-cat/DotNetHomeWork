using System;
using System.Collections.Generic;
using HomeWorkWebAPI.entities;

namespace HomeWorkWebAPI.models
{
    
    public class OrderDto
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> List { get; set; }
        public double TotalMoney { get; set; }

    }
}