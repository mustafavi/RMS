using RMS.Data.Models2;
using Microsoft.EntityFrameworkCore;

namespace RMS.Infrastructure
{
    public class RMSContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Data Source=;initial catalog = RMS");
        }


        public DbSet<Property> Property { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Rent> Rent { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<Expense> Expense { get; set; }

    }
}
