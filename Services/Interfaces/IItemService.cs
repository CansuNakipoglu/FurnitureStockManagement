using FurnitureStockManagement.Entities;
using FurnitureStockManagement.Object.Requests;

namespace FurnitureStockManagement.Services.Interfaces
{
    public interface IItemService
    {
        List<Item> GetAllItems();
        void CreateItem(CreateItemRequest requestItem);
    }
}
