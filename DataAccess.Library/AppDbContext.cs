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

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(p => p.ExternalCode);

                entity.HasMany(p => p.Values);
            });


            modelBuilder.Entity<Value>(entity =>
            {
                entity.HasKey(p => new { p.reg1Value, p.regDate });
            });
        }
    }
}




