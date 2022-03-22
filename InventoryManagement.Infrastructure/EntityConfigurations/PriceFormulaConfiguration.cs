using InventoryManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.EntityConfigurations
{
    public class PriceFormulaConfiguration : IEntityTypeConfiguration<PriceFormula>
    {
        public void Configure(EntityTypeBuilder<PriceFormula> builder)
        {
        }
    }
}
