using InventoryManagement.Domain.Common;
using System.Collections.Generic;

namespace InventoryManagement.Domain.Model
{
    public class ProductUom : Entity
    {
        public string Name { get; set; }
        public bool IsMainUnit { get; set; }
        public bool IsLargerThanMainUnit { get; set; }
        public decimal Multiplier { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public List<ProductPrice> ProductPrice { get; set; }
    }
}