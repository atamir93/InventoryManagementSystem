using InventoryManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.Persistence.EntityConfigurations
{
    public class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPrice>
    {
        public void Configure(EntityTypeBuilder<ProductPrice> builder)
        {
            builder.HasIndex(p => new { p.ProductUomId, p.PriceLevelId }).IsUnique();
            builder.HasOne(p => p.PriceFormula).WithOne(p => p.ProductPrice).HasForeignKey<ProductPrice>(p => p.PriceFormulaId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
