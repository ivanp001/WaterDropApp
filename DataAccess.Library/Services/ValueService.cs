using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Library.Services
{
    public class ValueService : IValueService
    {
        private readonly AppDbContext _db;

        public ValueService(AppDbContext db)
        {
            _db = db;
        }

        public Task<List<Value>> GetAllValuesAsync()
        {
            return _db.Values.ToListAsync();
        }

        public async Task AddValueAsync(Value Value)
        {
            _db.Values.Add(Value);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Value>> GetValuesByIdAsync(int Id)
        {
            //todo value  find by FirstOrDefaultAsync(x => x.reg1Value == Id)
            var ValueById = await _db.Values.ToListAsync();
 


            if (ValueById is null)
            {
                throw new Exception($"Value with Id: {Id} not found");
            }
            else
                return ValueById;
        }
    }
}
