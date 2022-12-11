using FurnitureStockManagement.Entities.Base;

namespace FurnitureStockManagement.Entities
{
    public class Stock : IEntity
    {
        public long Quantity { get; set; }
        public long ItemId { get; set; }
        public bool IsLocked { get; set; }
    }
}
