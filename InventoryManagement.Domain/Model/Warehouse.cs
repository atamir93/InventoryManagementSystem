using InventoryManagement.Domain.Common;
using System;
using System.Collections.Generic;

namespace InventoryManagement.Domain.Model
{
    public class Warehouse : Entity, IHistory
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public Address Address { get; set; }
        public List<ProductWarehouse> ProductWarehouses { get; set; }
        public DateTime CreatedDate { get; set; }
        //public List<Product> Products { get; set; }
    }
}