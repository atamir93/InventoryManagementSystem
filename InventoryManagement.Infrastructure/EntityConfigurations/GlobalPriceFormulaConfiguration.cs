using InventoryManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.EntityConfigurations
{
    public class GlobalPriceFormulaConfiguration : IEntityTypeConfiguration<GlobalPriceFormula>
    {
        public void Configure(EntityTypeBuilder<GlobalPriceFormula> builder)
        {
        }
    }
}
