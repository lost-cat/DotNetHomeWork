using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWorkWebAPI.entities
{
    public class Item
    {
        
        [Key] public Guid Id { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }
       
        public OrderDetail OrderDetail { get; set; }
        public Guid OrderDetailId { get; set; }
    }
}