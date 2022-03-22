using FluentValidation;
using InventoryManagement.Domain.Model;

namespace InventoryManagement.Infrastructure.Validators
{
    public class PriceFormulaValidator : AbstractValidator<PriceFormula>
    {
        public PriceFormulaValidator()
        {
            RuleFor(p => p.Amount).GreaterThanOrEqualTo(0);
        }
    }
}
