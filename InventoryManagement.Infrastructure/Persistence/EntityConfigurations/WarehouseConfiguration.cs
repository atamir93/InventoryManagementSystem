using InventoryManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.Persistence.EntityConfigurations
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.HasIndex(p => p.Name).IsUnique().HasDatabaseName("NameIndex"); //Index to improve DB Search performance
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

            builder.Property(p => p.CreatedDate).HasDefaultValueSql("getdate()");

            builder.OwnsOne(p => p.Address);
        }
    }
}
