using System;

namespace InventoryManagement.Domain
{
    public class ProductWarehouse
    {
        public decimal Available { get; set; }
        public decimal OnHand { get; set; }
        public decimal MinStockLevel { get; set; }
        public decimal MaxStockLevel { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}