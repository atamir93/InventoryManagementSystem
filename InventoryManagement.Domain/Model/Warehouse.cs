using InventoryManagement.Domain.Common;
using InventoryManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace InventoryManagement.Domain.Model
{
    public class Warehouse : Entity, ICreatedHistory
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Address Address { get; set; }
        public List<ProductWarehouse> ProductWarehouses { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}