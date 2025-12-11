using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Library
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Value> Values { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> Options)
        : base(Options)
        {
        }
        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Customer>(Entity =>
            {
                Entity.HasKey(p => p.ExternalCode);

                Entity.HasMany(p => p.Values);
            });


            ModelBuilder.Entity<Value>(Entity =>
            {
                Entity.HasKey(p => new { p.Reg1Value, p.RegDate });
            });
        }
    }
}




