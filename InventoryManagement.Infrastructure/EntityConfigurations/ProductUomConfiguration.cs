using InventoryManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.EntityConfigurations
{
    public class ProductUomConfiguration : IEntityTypeConfiguration<ProductUom>
    {
        public void Configure(EntityTypeBuilder<ProductUom> builder)
        {
        }
    }
}
