using System;
using System.Collections.Generic;
using System.Linq;
using HomeWorkWebAPI.entities;

namespace HomeWorkWebAPI.models
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public CustomerDto Customer { get; set; }
        public List<OrderDetailDto> List { get; set; }
        public double TotalMoney => List.Sum(d => d.Money);
    }
}