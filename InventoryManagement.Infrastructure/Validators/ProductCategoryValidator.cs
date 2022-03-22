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
            RuleFor(p => p.ParentCategoryId).NotEqual(p => p.Id)
                .DependentRules(() => RuleFor(p => p.ParentCategory).NotEqual(p => p));
            RuleFor(p => p.ParentCategory).Must(DoesNotContainParentCategory);
        }

        protected bool DoesNotContainParentCategory(ProductCategory currentCategory, ProductCategory parentCategory)
        {
            return currentCategory.AllChildCategories == null || !currentCategory.AllChildCategories.Contains(parentCategory);
        }
    }
}
