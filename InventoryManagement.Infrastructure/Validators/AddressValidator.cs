using FluentValidation;
using InventoryManagement.Domain.ValueObjects;

namespace InventoryManagement.Infrastructure.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(p => p.PostalCode).NotEmpty();
        }
    }
}
