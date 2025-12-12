using Microsoft.EntityFrameworkCore;

namespace DataAccess.Library.Services
{
    public class ValueService : IValueService
    {
        private readonly AppDbContext _db;

        public ValueService(AppDbContext db)
        {
            _db = db;
        }

        public async Task AddValueAsync(Value Value)
        {
            _db.Values.Add(Value);
            await _db.SaveChangesAsync();
        }
    }
}
