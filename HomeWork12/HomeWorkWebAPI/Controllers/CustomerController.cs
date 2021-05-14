using System;
using System.Threading.Tasks;
using AutoMapper;
using HomeWorkWebAPI.entities;
using HomeWorkWebAPI.models;
using HomeWorkWebAPI.services;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ICustomerRepository repository;

        public CustomerController(ICustomerRepository repository, IMapper mapper)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{customerId:guid}", Name = nameof(GetCustomer))]
        public async Task<ActionResult<Customer>> GetCustomer(Guid customerId)
        {
            var customer = await repository.GetCustomer(customerId);
            if (customer == null) return NotFound();

            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CustomerAddDto customerAdd)
        {
            if (customerAdd == null) return BadRequest();

            var customer = mapper.Map<Customer>(customerAdd);
            repository.AddCustomer(customer);
            await repository.SaveChangeAsync();
            var customerDto = mapper.Map<CustomerDto>(customer);
            return CreatedAtRoute(
                nameof(GetCustomer),
                new {customerId = customerDto.Id}, customerDto);
        }

        [HttpDelete("{customerId:guid}")]
        public async Task<IActionResult> DeleteCustomer(Guid customerId)
        {
            var customer = await repository.GetCustomer(customerId);
            if (customer == null) return NotFound();

            repository.DeleteCustomer(customer);
            await repository.SaveChangeAsync();
            return Ok();
        }
    }
}