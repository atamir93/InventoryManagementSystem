using InventoryManagement.Domain.Common;

namespace InventoryManagement.Domain.Model
{
    public class ProductPrice : Entity
    {
        public int? PriceFormulaId { get; set; }
        public PriceFormula PriceFormula { get; set; }

        public int ProductUomId { get; set; }
        public ProductUom ProductUom { get; set; }

        public int PriceLevelId { get; set; }
        public PriceLevel PriceLevel { get; set; }

        public decimal Price { get; set; }
    }
}