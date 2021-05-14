using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeWorkWebAPI.entities;

namespace HomeWorkWebAPI.services
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomers();

        Task<Customer> GetCustomer(Guid id);

        Customer AddCustomer(Customer customer);

        void DeleteCustomer(Customer customer);

        Task<bool> SaveChangeAsync();
    }
}