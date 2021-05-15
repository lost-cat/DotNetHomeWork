using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HomeWorkWebAPI.entities;
using HomeWorkWebAPI.models;
using HomeWorkWebAPI.services;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository repository;
        private readonly IMapper mapper;

        public OrderController(IOrderRepository repository, IMapper mapper)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrders()
        {
            var orders = await repository.GetOrders();
            return Ok(orders);
        }

        [HttpGet("{orderId:guid}", Name = nameof(GetOrder))]
        public async Task<ActionResult<Order>> GetOrder(Guid orderId)
        {
            var order = await repository.GetOrder(orderId);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(OrderAddDto orderAdd)
        {
            if (orderAdd == null)
            {
                return BadRequest();
            }

            var order = mapper.Map<Order>(orderAdd);
            repository.AddOrder(order);
            await repository.SaveChangesAsync();
            var orderDto = mapper.Map<OrderDto>(order);
            return CreatedAtRoute(nameof(GetOrder), 
                new {orderId = orderDto.Id},
                orderDto);
        }
    }
}