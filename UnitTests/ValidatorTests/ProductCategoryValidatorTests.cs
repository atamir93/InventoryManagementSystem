using InventoryManagement.Infrastructure.Validators;
using NUnit.Framework;

namespace UnitTests.ValidatorTests
{
    public class ProductCategoryValidatorTests
    {
        private ProductCategoryValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new ProductCategoryValidator();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
