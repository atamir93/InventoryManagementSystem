using InventoryManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.Persistence.EntityConfigurations
{
    public class PriceLevelConfiguration : IEntityTypeConfiguration<PriceLevel>
    {
        public void Configure(EntityTypeBuilder<PriceLevel> builder)
        {
            builder.HasIndex(p => p.Name).IsUnique().HasDatabaseName("NameIndex"); //Index to improve DB Search performance
            builder.Property(p => p.Name).IsRequired().HasMaxLength(20);
        }
    }
}
