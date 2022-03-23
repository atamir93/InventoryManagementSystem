using InventoryManagement.Domain.Common;
using System;
using System.Collections.Generic;

namespace InventoryManagement.Domain.Model
{
    public class ProductCategory : Entity, ICreatedHistory, IAggregateRoot
    {
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }

        public int? ParentCategoryId { get; set; } //When ForeignKey is not nullable then it will be Cascade Delete, Product will be deleted on deleting category
        public ProductCategory ParentCategory { get; set; }
        public List<ProductCategory> ChildCategories { get; set; }

        /// <summary>
        /// Products only in current category
        /// </summary>
        public List<Product> Products { get; set; }

        /// <summary>
        /// All products including products in child categories
        /// </summary>
        public List<Product> AllProducts { get; set; }

        /// <summary>
        /// All child categories
        /// </summary>
        public List<ProductCategory> AllChildCategories { get; set; }
    }
}
