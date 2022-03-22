using InventoryManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.EntityConfigurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("Categories");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);

            builder.Property(p => p.CreatedDate).HasDefaultValueSql("getdate()");

            builder.Ignore(p => p.AllProducts);

            builder.HasMany(p => p.ChildCategories).WithOne(p => p.ParentCategory);
        }
    }
}
