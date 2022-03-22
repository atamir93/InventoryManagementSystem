namespace InventoryManagement.Domain
{
    public class ProductPrice : Entity
    {
        //public int ProductUomId { get; set; }
        //public ProductUom ProductUom { get; set; }
        //public PriceFormula PriceFormula { get; set; }
        public PriceLevel PriceLevel { get; set; }
        public int PriceLevelId { get; set; }
        public decimal Price { get; set; }
    }
}