
namespace DataAccess.Library.Services
{
    public interface IValueService
    {
        Task AddValueAsync(Value Value);
        Task<List<Value>> GetAllValuesAsync();
        Task<List<Value>> GetValuesByIdAsync(int Id);
    }
}