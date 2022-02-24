using RestaurantPaymentSystem.Data.Models;

namespace RestaurantPaymentSystem.Data.Services
{
    public interface ITableService
    {

        Task<TableModel> CreateTable(TableModel tableModel);

        Task<TableModel> GetTableById(int id);

        Task UpdateTable(TableModel tableModel);
    }
}
