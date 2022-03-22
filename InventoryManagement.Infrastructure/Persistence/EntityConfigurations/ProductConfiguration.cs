using InventoryManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.Persistence.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(p => p.Sku).IsUnique().HasDatabaseName("SkuIndex"); //Index to improve DB Search performance
            builder.Property(p => p.Sku).HasMaxLength(50);
            builder.Property(p => p.Name).HasMaxLength(200);
            builder.Property(p => p.Weight).HasColumnName("UnitWeight");

            builder.Property(p => p.IsActive).HasDefaultValue(true);
            builder.Property(p => p.TrackingType).HasDefaultValue(TrackingType.Fifo);
            builder.Property(p => p.CreatedDate).HasDefaultValueSql("getdate()");

            builder.Ignore(p => p.OnHand);
            builder.Ignore(p => p.MainUnit);

            builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
            //builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryName).HasPrincipalKey(c => c.Name);
        }
    }
}
