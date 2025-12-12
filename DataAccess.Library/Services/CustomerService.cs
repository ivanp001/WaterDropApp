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

        public async Task AddCustomerAsync(Customer Customer)
        {
            _db.Customer.Add(Customer);
            await _db.SaveChangesAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int Id)
        {
            //FindAsync() lookup of a single entity when its primary key is known
            var CustomerById = await _db.Customer.FindAsync(Id);

            if (CustomerById is not null)
            {
                return CustomerById;
            }
            else
            {
                throw new Exception($"Customer with Id: {Id} not found");
            }
        }

        public async Task UpdateCustomerAsync(Customer Customer)

        {
            var ExistingCustomer = await _db.Customer.FindAsync(Customer.ExternalCode);
            if (ExistingCustomer is not null)
            {
                _db.Entry(ExistingCustomer).CurrentValues.SetValues(Customer);
            }
            await _db.SaveChangesAsync();

            var customers = _db.Customer.ToListAsync();

        }

        public async Task DeleteCustomerAsync(int CustomerId)
        {
            var ExistingCustomer = await _db.Customer.FindAsync(CustomerId);
            if (ExistingCustomer is not null)
            {
                _db.Customer.Remove(ExistingCustomer);
            }
            await _db.SaveChangesAsync();
        }
    }
}

