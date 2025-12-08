using Microsoft.EntityFrameworkCore;
using WaterDropApp.Models.WaterDropApp;

namespace WaterDropApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Customer> Customer { get; set; }
    }
}
