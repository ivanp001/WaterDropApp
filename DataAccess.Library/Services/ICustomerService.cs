
using System.Threading.Tasks;

namespace DataAccess.Library.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task AddCustomerAsync(Customer Customer);
        Task UpdateCustomerAsync(Customer Customer);
        Task<Customer> GetCustomerByIdAsync(int Id);
    }
}