using System;
using System.Collections.Generic;
using HomeWorkWebAPI.entities;

namespace HomeWorkWebAPI.models
{
    public class OrderAddDto
    {
        public DateTime Time { get; set; }
        public CustomerAddDto Customer { get; set; }
        public List<OrderDetailAddDto> List { get; set; }
    }
}