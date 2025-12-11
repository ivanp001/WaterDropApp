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
            var CustomerById = await _db.Customer.FindAsync(Id);
            if (CustomerById is null)
            {
                throw new Exception($"Customer with Id: {Id} not found");
            }
            else
                return CustomerById;
        }

        public async Task UpdateCustomerAsync(Customer Customer)
        {
            var ExistingCustomer = _db.Customer.FindAsync(Customer.ExternalCode);
            if (ExistingCustomer.Result is null)
            {
                throw new Exception($"Customer with Id {Customer.ExternalCode} not found.");
            }
            else
            {
                ExistingCustomer.Result.MpCode = Customer.MpCode;
                ExistingCustomer.Result.Name = Customer.Name;
                ExistingCustomer.Result.Street = Customer.Street;
                ExistingCustomer.Result.SerialNo = Customer.SerialNo;
                ExistingCustomer.Result.Values = Customer.Values;
                //to do map  values
            }
            _db.Update(Customer);
            await _db.SaveChangesAsync();
        }




        //public async Task DeleteCustomerAsync(Customer customer)
        //{
        //    //_db.Customer.Add(customer);
        //    //await _db.SaveChangesAsync();
        //}
    }
}

