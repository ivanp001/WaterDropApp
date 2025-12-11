
using System.Threading.Tasks;

namespace DataAccess.Library.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task AddCustomerAsync(Customer customer);
        Task UpdateCustomerAsync(Customer customer);
        Task<Customer> GetCustomerByIdAsync(int Id);
    }
}