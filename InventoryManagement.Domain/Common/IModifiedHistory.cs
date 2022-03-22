using System;

namespace InventoryManagement.Domain.Common
{
    public interface IModifiedHistory
    {
        DateTime ModifiedDate { get; set; }
    }
}
