using FluentValidation;
using InventoryManagement.Domain.Model;

namespace InventoryManagement.Infrastructure.Validators
{
    public class WarehouseValidator : AbstractValidator<Warehouse>
    {
        public WarehouseValidator()
        {
            RuleFor(p => p.Address).SetValidator(new AddressValidator());
            //RuleFor(p => p.Address.PostalCode).NotEmpty().When(p => p.Address != null);
        }
    }
}
