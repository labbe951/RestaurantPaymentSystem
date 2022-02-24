using API.Data.Models;
using API.Data.Repositories;

namespace API.Data.Services
{
    public class TableService : ITableService
    {
        private readonly IAsyncRepository<TableModel> _asyncRepository;

        public TableService(IAsyncRepository<TableModel> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }


        public async Task<TableModel> CreateTable(TableModel tableModel)
        {

            return await _asyncRepository.AddAsync(tableModel);

        }
    }
}
