using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkWebAPI.entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public List<OrderDetail> List { get; set; }
        public DateTime Time { get; set; }
        public double TotalMoney => List.Sum(d => d.Money);


        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
    }
}