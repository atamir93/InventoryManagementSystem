using InventoryManagement.Domain.Common;
using System.Collections.Generic;

namespace InventoryManagement.Domain.Model
{
    public class PriceLevel : Entity
    {
        public string Name { get; set; }
        public List<ProductUom> ProductUoms { get; set; }
    }
}
