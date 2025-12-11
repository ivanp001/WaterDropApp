using Microsoft.EntityFrameworkCore;

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
                Entity.Property<int>(x => x.ExternalCode)
               .ValueGeneratedOnAdd();

                Entity.Property(p => p.Name);
                Entity.Property(p => p.Street);
                Entity.Property(p => p.MpCode);
                Entity.Property(p => p.SerialNo);
                Entity.HasKey(p => p.ExternalCode);
                Entity.HasMany(p => p.Values);

            });

            ModelBuilder.Entity<Value>(Entity =>
            {
                //Entity.Property<int?>("CustomerId");
                Entity.Property(x => x.Reg1Value);
                Entity.Property(x => x.RegDate);
                Entity.Property(x => x.ValueTypeDescription);
                Entity.Property(x => x.ValueTypeUnit);

                Entity.HasKey(x => new { x.Reg1Value, x.RegDate });

                Entity.HasOne<Customer>()
                  .WithMany(c => c.Values);
                //.HasForeignKey("CustomerId");
            });
        }
    }
}




