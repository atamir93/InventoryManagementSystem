using System;

namespace InventoryManagement.Domain.Common
{
    public interface ICreatedHistory
    {
        DateTime CreatedDate { get; set; }
    }
}
