using InventoryManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.EntityConfigurations
{
    public class ProductWarehouseConfiguration : IEntityTypeConfiguration<ProductWarehouse>
    {
        public void Configure(EntityTypeBuilder<ProductWarehouse> builder)
        {
            builder.Property(p => p.CreatedDate).HasDefaultValueSql("getdate()");

            builder.Ignore(p => p.Available);
            builder.Ignore(p => p.OnHand);

            builder.HasKey(t => new { t.ProductId, t.WarehouseId });
            builder.HasOne(pw => pw.Product).WithMany(p => p.ProductWarehouses).HasForeignKey(p => p.ProductId);
            builder.HasOne(pw => pw.Warehouse).WithMany(p => p.ProductWarehouses).HasForeignKey(p => p.WarehouseId);
        }
    }
}
