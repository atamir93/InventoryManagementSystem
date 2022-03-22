using System;

namespace InventoryManagement.Domain.Common
{
    public interface IHistory
    {
        DateTime CreatedDate { get; set; }
    }
}
