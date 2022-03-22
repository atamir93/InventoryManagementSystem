using InventoryManagement.Domain.Common;

namespace InventoryManagement.Domain.Model
{
    public abstract class PriceFormula : Entity
    {
        public decimal Amount { get; set; }
        public ProductPrice ProductPrice { get; set; }
    }
}
