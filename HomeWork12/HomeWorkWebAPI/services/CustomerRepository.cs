using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeWorkWebAPI.data;
using HomeWorkWebAPI.entities;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkWebAPI.services
{
    internal class CustomerRepository : ICustomerRepository
    {
        private readonly OrderContext context;

        public CustomerRepository(OrderContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomer(Guid id)
        {
            return await context.Customers.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Customer AddCustomer(Customer customer)
        {
            customer.Id = Guid.NewGuid();
            var add = context.Customers.Add(customer);
            return add.Entity;
        }

        public void DeleteCustomer(Customer customer)
        {
            context.Remove(customer);
        }

        public async Task<bool> SaveChangeAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }
    }
}