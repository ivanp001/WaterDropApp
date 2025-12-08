using DataAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WaterDropApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController(AppDbContext _dbContext) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetValue()
        {
            return await _dbContext.Customer.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> AddValue(Customer customer)
        {
            _dbContext.Customer.Add(customer);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction("GetCustomer", new { id = customer.ExternalCode }, customer);
        }
    }
}
