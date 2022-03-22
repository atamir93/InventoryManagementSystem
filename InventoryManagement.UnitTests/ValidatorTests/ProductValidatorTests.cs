using FluentValidation.TestHelper;
using InventoryManagement.Domain.Model;
using InventoryManagement.Infrastructure.Validators;
using NUnit.Framework;
using System.Collections.Generic;

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

        [TestCase]
        public void ShouldHaveError_WhenTrackingTypeValue_IsNotInEnum()
        {
            validator.ShouldHaveValidationErrorFor(p => p.TrackingType, (TrackingType)4);
        }

        [TestCase]
        public void ShouldNotHaveError_WhenTrackingTypeValue_IsInEnum()
        {
            validator.ShouldNotHaveValidationErrorFor(p => p.TrackingType, (TrackingType)3);
        }

        [TestCase(-1)]
        [TestCase(51)]
        public void ShouldHaveError_WhenWeight_IsNotInclusiveBetweenZeroAndFifty(decimal weight)
        {
            validator.ShouldHaveValidationErrorFor(p => p.Weight, weight);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(49)]
        [TestCase(50)]
        public void ShouldNotHaveError_WhenWeight_IsInclusiveBetweenZeroAndFifty(decimal weight)
        {
            validator.ShouldNotHaveValidationErrorFor(p => p.Weight, weight);
        }

        [TestCase]
        public void ShouldNotHaveError_WhenProductUoms_IsEmpty()
        {
            validator.ShouldNotHaveValidationErrorFor(p => p.ProductUoms, new List<ProductUom>());
        }

        [TestCase(false, false)]
        [TestCase(true, true)]
        public void ShouldHaveError_WhenProductUoms_ContainsNotExactOneMainUnit(bool isFirstUomMain, bool isSecondUomMain)
        {
            var productUom1 = new ProductUom() { IsMainUnit = isFirstUomMain };
            var productUom2 = new ProductUom() { IsMainUnit = isSecondUomMain };
            var productUoms = new List<ProductUom>() { productUom1, productUom2 };
            validator.ShouldHaveValidationErrorFor(p => p.ProductUoms, productUoms);
        }

        [TestCase]
        public void ShouldNotHaveError_WhenProductUoms_ContainsExactOneMainUnit()
        {
            var productUom1 = new ProductUom() { IsMainUnit = true };
            var productUom2 = new ProductUom() { IsMainUnit = false };
            var productUoms = new List<ProductUom>() { productUom1, productUom2 };
            validator.ShouldNotHaveValidationErrorFor(p => p.ProductUoms, productUoms);
        }
    }
}
