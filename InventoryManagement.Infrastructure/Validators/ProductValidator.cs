using FluentValidation;
using InventoryManagement.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement.Infrastructure.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //CascadeMode = CascadeMode.Stop;

            RuleFor(p => p.Cost).GreaterThanOrEqualTo(0);
            RuleFor(p => p.Weight).InclusiveBetween(0, 50);

            RuleFor(p => p.ProductUoms).Must(ContainOneMainUnit).WithMessage("Product Uoms list must contain exact one main unit").When(p => p.ProductUoms != null && p.ProductUoms.Any());

            RuleFor(p => p.TrackingType).IsInEnum();
        }

        protected bool ContainOneMainUnit(List<ProductUom> uoms)
        {
            return uoms.Count(u => u.IsMainUnit) == 1;
        }
    }
}
