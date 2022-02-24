using RestaurantPaymentSystem.Data.Models;
using RestaurantPaymentSystem.Data.Repositories;

namespace RestaurantPaymentSystem.Data.Services
{
    public class TableService : ITableService
    {
        private readonly IAsyncRepository<TableModel> _asyncRepository;

        public TableService(IAsyncRepository<TableModel> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }

        public async Task<TableModel> GetTableById(int id)
        {

            return await _asyncRepository.GetByIdAsync(id);

        }
        public async Task<TableModel> CreateTable(TableModel tableModel)
        {

            return await _asyncRepository.AddAsync(tableModel);

        }

        public async Task UpdateTable(TableModel tableModel)
        {

            await _asyncRepository.UpdateAsync(tableModel);

        }
    }
}
