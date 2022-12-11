using FurnitureStockManagement.Entities.Base;

namespace FurnitureStockManagement.Entities
{
    public class User : IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

    }
}
