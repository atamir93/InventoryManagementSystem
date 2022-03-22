using InventoryManagement.Domain.Model;
using InventoryManagement.Infrastructure.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<PriceLevel> PriceLevels { get; set; }

        public ApplicationDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //UseLazyLoadingProxies()  requires only the navigation properties be virtual
            //optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = InventoryManagement; Trusted_Connection = True; ",options => options.MaxBatchSize(100));

            var connectionString = "Server = (localdb)\\mssqllocaldb; Database = InventoryManagementSystem; Trusted_Connection = True; ";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
            modelBuilder.ApplyConfiguration(new ProductWarehouseConfiguration());
            modelBuilder.ApplyConfiguration(new PriceLevelConfiguration());
            modelBuilder.ApplyConfiguration(new ProductUomConfiguration());
            modelBuilder.ApplyConfiguration(new ProductPriceConfiguration());
            modelBuilder.ApplyConfiguration(new PriceFormulaConfiguration());
        }
    }
}
