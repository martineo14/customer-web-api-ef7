using CustomerWebApi.DAL.Entities;
using Microsoft.Data.Entity;

namespace CustomerWebApi.DAL
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Filename=Customer.db");
        }
    }
}