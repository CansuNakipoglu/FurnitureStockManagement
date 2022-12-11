using FurnitureStockManagement.Entities;
using FurnitureStockManagement.Object.Requests;
using FurnitureStockManagement.Repositories.Interfaces;
using FurnitureStockManagement.Services.Interfaces;

namespace FurnitureStockManagement.Services
{
    public class ItemService : IItemService
    {
        public IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public List<Item> GetAllItems()
        {
            return _itemRepository.GetAllItems(5);
        }

        public void CreateItem(CreateItemRequest requestItem)
        {
            var item = new Item
            {
                Name = requestItem.Name,
                ColorId = requestItem.ColorId,
                ImageURL = requestItem.ImageURL,
                CreatedDate = DateTime.Now,
                UpdatedDate= DateTime.Now,
                CreatedUserId = 1,
                Description = requestItem.Description
            };

            _itemRepository.CreateItem(item);
        }

    }
}
