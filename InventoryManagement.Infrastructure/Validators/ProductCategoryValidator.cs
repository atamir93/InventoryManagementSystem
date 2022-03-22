using FluentValidation;
using InventoryManagement.Domain.Model;

namespace InventoryManagement.Infrastructure.Validators
{
    public class ProductCategoryValidator : AbstractValidator<ProductCategory>
    {
        public ProductCategoryValidator()
        {
            //Default error message: '{PropertyName}’ must not be empty.
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.ParentCategoryId).NotEqual(p => p.Id);
            RuleForEach(p => p.AllChildCategories).NotEqual(p => p.ParentCategory);
        }
    }
}
