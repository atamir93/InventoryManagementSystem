using InventoryManagement.Domain.Common;
using System;
using System.Collections.Generic;

namespace InventoryManagement.Domain.Model
{
    public class Product : Entity, ICreatedHistory, IAggregateRoot
    {
        public DateTime CreatedDate { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal Weight { get; set; }
        public bool IsActive { get; set; }
        public int OnHand { get; set; }
        public TrackingType TrackingType { get; set; }

        //public string CategoryName { get; set; }
        public int? CategoryId { get; set; } //When ForeignKey is not nullable then it will be Cascade Delete, Product will be deleted on deleting category
        public ProductCategory Category { get; set; }

        public ProductUom MainUnit { get; set; }
        public List<ProductUom> ProductUoms { get; set; }

        public List<ProductWarehouse> ProductWarehouses { get; set; }

    }
}