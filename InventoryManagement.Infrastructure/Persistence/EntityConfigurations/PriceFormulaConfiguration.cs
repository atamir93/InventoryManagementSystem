using InventoryManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryManagement.Infrastructure.Persistence.EntityConfigurations
{
    public class PriceFormulaConfiguration : IEntityTypeConfiguration<PriceFormula>
    {
        public void Configure(EntityTypeBuilder<PriceFormula> builder)
        {
        }
    }
}
