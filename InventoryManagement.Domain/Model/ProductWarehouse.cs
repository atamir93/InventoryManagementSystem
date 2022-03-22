using InventoryManagement.Domain.Common;
using System;

namespace InventoryManagement.Domain.Model
{
    public class ProductWarehouse : ICreatedHistory
    {
        public decimal Available { get; set; }
        public decimal OnHand { get; set; }
        public decimal MinStockLevel { get; set; }
        public decimal MaxStockLevel { get; set; }
        public DateTime CreatedDate { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}