using FurnitureStockManagement.Entities;

namespace FurnitureStockManagement.Repositories.Interfaces
{
    public interface IItemRepository
    {
        List<Item> GetAllItems(int takeSize);
        void CreateItem(Item requestItem);
    }
}
