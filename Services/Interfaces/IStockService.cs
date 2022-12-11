using FurnitureStockManagement.Entities;
using FurnitureStockManagement.Object.Requests;

namespace FurnitureStockManagement.Services.Interfaces
{
    public interface IStockService
    {
            List<Stock> GetAllStocks();
            void CreateStock(CreateStockRequest requestStock);
        }
}
