using FluentValidation.TestHelper;
using InventoryManagement.Infrastructure.Validators;
using NUnit.Framework;

namespace InventoryManagement.UnitTests.ValidatorTests
{
    public class ProductValidatorTests
    {
        ProductValidator validator = null;

        [SetUp]
        public void Setup()
        {
            validator = new ProductValidator();
        }

        [TestCase]
        public void ShouldHaveError_WhenCost_IsLessThanZero()
        {
            validator.ShouldHaveValidationErrorFor(p => p.Cost, -1);
        }

        [TestCase(0)]
        [TestCase(1)]
        public void ShouldNotHaveError_WhenCost_IsGreaterThanOrEqualToZero(decimal cost)
        {
            validator.ShouldNotHaveValidationErrorFor(p => p.Cost, cost);
        }
    }
}
