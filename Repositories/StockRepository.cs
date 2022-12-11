using FurnitureStockManagement.Data;
using FurnitureStockManagement.Entities;
using FurnitureStockManagement.Repositories.Interfaces;

namespace FurnitureStockManagement.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly DataContext _dataContext;

        public StockRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Stock> GetAllStock(int takeSize)
        {
            return _dataContext.Stocks.ToList();
        }

        public void CreateStock(Stock requestStock)
        {
            _dataContext.Stocks.Add(requestStock);
            _dataContext.SaveChanges();
        }
    }
}
