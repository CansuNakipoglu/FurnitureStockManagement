using System.ComponentModel.DataAnnotations;

namespace FurnitureStockManagement.Entities.Base
{
    public abstract class IEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long CreatedUserId { get; set; }
        public long UpdatedUserId { get; set; }
    }
}
