using System;

namespace HomeWorkWebAPI.entities
{
    public class Item
    {
        public Guid Id { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }

        public Guid OrderDetailId { get; set; }
        public OrderDetail OrderDetail { get; set; }
        
    }
}