using FurnitureStockManagement.Entities;
using FurnitureStockManagement.Object.Requests;
using FurnitureStockManagement.Repositories;
using FurnitureStockManagement.Repositories.Interfaces;
using FurnitureStockManagement.Services.Interfaces;

namespace FurnitureStockManagement.Services
{
    public class StockService : IStockService
    {
        public IStockRepository _stockRepository;
        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }


        public void CreateStock(CreateStockRequest requestStock)
        {
            var stock = new Stock
            {
                Quantity = requestStock.Quantity,
                ItemId = requestStock.ItemId,
                IsLocked = requestStock.Islocked,
                CreatedDate = DateTime.Now,
                CreatedUserId = 1,
                UpdatedDate = DateTime.Now,
                UpdatedUserId = 1,

            };
            _stockRepository.CreateStock(stock);
        }
        public List<Stock> GetAllStocks()
        {
            return _stockRepository.GetAllStock(12);
        }

    }
}

