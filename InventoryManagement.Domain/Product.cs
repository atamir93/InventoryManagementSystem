using System.Collections.Generic;

namespace InventoryManagement.Domain
{
    public class Product : Entity
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public decimal Weight { get; set; }
        public bool IsActive { get; set; }
        public int OnHand { get; set; }

        public ProductCategory Category { get; set; }
        //public int CategoryKey { get; set; }
        //public string CategoryName { get; set; }
        //public int CategoryId { get; set; } //When ForeignKey is not nullable then it will be Cascade Delete, on Product will be deleted on deleting category
        public int? CategoryId { get; set; }
        public List<ProductUom> ProductUoms { get; set; }
        public List<ProductWarehouse> ProductWarehouses { get; set; }
        //public List<Warehouse> Warehouses { get; set; }
    }
}