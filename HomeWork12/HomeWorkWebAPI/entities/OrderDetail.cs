using System;

namespace HomeWorkWebAPI.entities
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Item Item { get; set; }
        public int Count { get; set; }
        public double Money => Item.Price * Count;

        public Guid ItemId { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}