using FurnitureStockManagement.Entities;

namespace FurnitureStockManagement.Repositories.Interfaces
{
    public interface IStockRepository
    {
        List<Stock> GetAllStock(int takeSize);
        void CreateStock(Stock requestStock);
    }
}
