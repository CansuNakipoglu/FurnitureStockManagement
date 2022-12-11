using FurnitureStockManagement.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureStockManagement.Entities
{
    [Table("Items", Schema = "Inventory")]
    public class Item : IEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public int ColorId { get; set; }
    }
}
