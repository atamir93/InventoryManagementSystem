using FluentValidation;
using InventoryManagement.Domain.Model;
using System.Collections.Generic;
using System.Linq;

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
            //RuleForEach(p => p.AllChildCategories).NotEqual(p => p.ParentCategory);
            RuleFor(p => p.ParentCategory).Must(DoesNotContainParentCategory);
        }

        protected bool DoesNotContainParentCategory(ProductCategory currentCategory, ProductCategory parentCategory)
        {
            return currentCategory.AllChildCategories == null || !currentCategory.AllChildCategories.Contains(parentCategory);
        }
    }
}
