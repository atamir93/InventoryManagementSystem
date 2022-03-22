using System.Collections.Generic;

namespace InventoryManagement.Domain
{
    public class ProductCategory : Entity
    {
        public string Name { get; set; }

        public ProductCategory ParentCategory { get; set; }
        public int? ParentCategoryId { get; set; }

        public List<ProductCategory> ChildCategories { get; set; }
        public List<Product> Products { get; set; }
    }
}
