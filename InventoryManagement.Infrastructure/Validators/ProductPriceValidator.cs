using FluentValidation;
using InventoryManagement.Domain.Model;

namespace InventoryManagement.Infrastructure.Validators
{
    public class ProductPriceValidator : AbstractValidator<ProductPrice>
    {
        public ProductPriceValidator()
        {
            RuleFor(p => p.Price).GreaterThanOrEqualTo(0);
        }
    }
}
