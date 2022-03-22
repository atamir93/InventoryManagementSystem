using FluentValidation;
using InventoryManagement.Domain.Model;

namespace InventoryManagement.Infrastructure.Validators
{
    public class ProductUomValidator : AbstractValidator<ProductUom>
    {
        public ProductUomValidator()
        {
            RuleFor(p => p.Multiplier).GreaterThan(0);
        }
    }
}
