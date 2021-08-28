using EntityFrameworkTask;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<ProviderType> ProviderTypes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=VIKTORIAPC; Initial Catalog=EFDatabase; Integrated Security=true");
        }
    }
}
