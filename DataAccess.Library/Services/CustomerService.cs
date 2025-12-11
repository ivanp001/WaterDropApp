using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static DataAccess.Library.Services.CustomerService;

namespace DataAccess.Library.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _db;

        public CustomerService(AppDbContext db)
        {
            _db = db;
        }

        public Task<List<Customer>> GetAllCustomersAsync()
        {
            return _db.Customer.ToListAsync();
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            _db.Customer.Add(customer);
            await _db.SaveChangesAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int Id)
        {
            var customerById = await _db.Customer.FindAsync(Id);
            if (customerById is null)
            {
                throw new Exception($"Customer with Id: {Id} not found");
            }
            else
                return customerById;
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            var existingCustomer = _db.Customer.FindAsync(customer.ExternalCode);
            if (existingCustomer.Result is null)
            {
                throw new Exception($"Customer with Id {customer.ExternalCode} not found.");
            }
            else
            {
                existingCustomer.Result.MpCode = customer.MpCode;
                existingCustomer.Result.Name = customer.Name;
                existingCustomer.Result.Street = customer.Street;
                existingCustomer.Result.SerialNo = customer.SerialNo;
                existingCustomer.Result.Values = customer.Values;
                //to do map  values
            }
            _db.Update(customer);
            await _db.SaveChangesAsync();
        }




        //public async Task DeleteCustomerAsync(Customer customer)
        //{
        //    //_db.Customer.Add(customer);
        //    //await _db.SaveChangesAsync();
        //}
    }
}

