using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure
{
    public class InventoryManagementContext : DbContext
    {
        public InventoryManagementContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //UseLazyLoadingProxies()  requires only the navigation properties be virtual
            //optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = InventoryManagement; Trusted_Connection = True; ",options => options.MaxBatchSize(100));
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = InventoryManagementSystem; Trusted_Connection = True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
