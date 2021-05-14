using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeWorkWebAPI.data;
using HomeWorkWebAPI.entities;
using HomeWorkWebAPI.services;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository repository;

        public OrderController(IOrderRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrders()
        {
            var orders = await repository.GetOrders();
            
            return new JsonResult(orders);
        }
    }
}