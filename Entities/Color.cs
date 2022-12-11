using FurnitureStockManagement.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureStockManagement.Entities
{
    [Table("Color", Schema = "Master")]
    public class Color : IEntity
    {
        public string Name { get; set; }
    }
}
