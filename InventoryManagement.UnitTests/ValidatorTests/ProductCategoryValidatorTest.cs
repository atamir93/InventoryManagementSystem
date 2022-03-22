using FluentValidation.TestHelper;
using InventoryManagement.Domain.Model;
using InventoryManagement.Infrastructure.Validators;
using NUnit.Framework;
using System.Collections.Generic;

namespace InventoryManagement.UnitTests.ValidatorTests
{
    public class ProductCategoryValidatorTest
    {
        ProductCategoryValidator validator = null;

        [SetUp]
        public void Setup()
        {
            validator = new ProductCategoryValidator();
        }

        [TestCase]
        public void ShouldHaveError_WhenName_IsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(p => p.Name, string.Empty);
        }

        [TestCase]
        public void ShouldNotHaveError_WhenName_IsNotEmpty()
        {
            validator.ShouldNotHaveValidationErrorFor(p => p.Name, "Others");
        }

        [TestCase]
        public void ShouldHaveError_WhenParentCategory_IsEqualToCurrentCategory()
        {
            var category = new ProductCategory();
            category.ParentCategory = category;
            var result = validator.TestValidate(category);
            result.ShouldHaveValidationErrorFor(p => p.ParentCategory);
        }

        [TestCase]
        public void ShouldNotHaveError_WhenParentCategory_IsNotEqualtToCurrentCategory()
        {
            var category = new ProductCategory();
            category.ParentCategory = new ProductCategory();
            var result = validator.TestValidate(category);
            result.ShouldNotHaveValidationErrorFor(p => p.ParentCategory);
        }

        [TestCase]
        public void ShouldHaveError_WhenParentCategory_IsInAllChidCategoriesList()
        {
            var childCategory1 = new ProductCategory();
            var parentCategory = new ProductCategory();
            var categories = new List<ProductCategory> { childCategory1, parentCategory };

            var category = new ProductCategory() { AllChildCategories = categories, ParentCategory = parentCategory };
            var result = validator.TestValidate(category);
            result.ShouldHaveValidationErrorFor(p => p.ParentCategory);
        }

        [TestCase]
        public void ShouldNotHaveError_WhenParentCategory_IsNotInAllChildCategoriesList()
        {
            var childCategory1 = new ProductCategory();
            var parentCategory = new ProductCategory();
            var categories = new List<ProductCategory> { childCategory1 };

            var category = new ProductCategory() { AllChildCategories = categories, ParentCategory = parentCategory };
            var result = validator.TestValidate(category);
            result.ShouldNotHaveValidationErrorFor(p => p.ParentCategory);
        }
    }
}
