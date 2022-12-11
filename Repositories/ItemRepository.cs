using FurnitureStockManagement.Data;
using FurnitureStockManagement.Entities;
using FurnitureStockManagement.Repositories.Interfaces;
using Microsoft.VisualBasic;

namespace FurnitureStockManagement.Repositories
{
    public class ItemRepository : IItemRepository 
    {
        private readonly DataContext _dataContext;

        public ItemRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Item> GetAllItems(int takeSize)
        {
            return _dataContext.Items.ToList();
        }

        public void CreateItem(Item requestItem)
        {
            _dataContext.Items.Add(requestItem);
            _dataContext.SaveChanges();
        }
    }
}
