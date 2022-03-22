using FluentValidation;
using InventoryManagement.Domain.Model;

namespace InventoryManagement.Infrastructure.Validators
{
    public class ProductWarehouseValidator : AbstractValidator<ProductWarehouse>
    {
        public ProductWarehouseValidator()
        {
            RuleFor(p => p.MinStockLevel).GreaterThanOrEqualTo(0);
            RuleFor(p => p.MaxStockLevel).GreaterThan(p => p.MinStockLevel);
        }
    }
}
