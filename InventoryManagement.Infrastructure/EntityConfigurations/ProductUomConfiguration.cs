using InventoryManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.EntityConfigurations
{
    public class ProductUomConfiguration : IEntityTypeConfiguration<ProductUom>
    {
        public void Configure(EntityTypeBuilder<ProductUom> builder)
        {
            builder.HasIndex(p => new { p.Name, p.ProductId }).IsUnique();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);

            builder.Property(p=>p.IsLargerThanMainUnit).HasDefaultValue(true);
        }
    }
}
