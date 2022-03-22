using InventoryManagement.Domain.Common;

namespace InventoryManagement.Domain.Model
{
    public abstract class PriceFormula : Entity
    {
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public ProductPrice ProductPrice { get; set; }
    }
}
