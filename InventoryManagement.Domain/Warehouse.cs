using System;
using System.Collections.Generic;

namespace InventoryManagement.Domain
{
    public class Warehouse : Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public Address Address { get; set; }
        public List<ProductWarehouse> ProductWarehouses { get; set; }
        //public List<Product> Products { get; set; }
    }
}