using API.Data.Models;
using API.Data.Repositories;

namespace API.Data.Services
{
    public class DishService : IDishService
    {
        private readonly IAsyncRepository<DishModel> _asyncRepository;

        public DishService(IAsyncRepository<DishModel> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }



        public async Task<DishModel> GetDishById(int id)
        {

            return await _asyncRepository.GetByIdAsync(id);

        }

        public async Task<DishModel> CreateDishModel(DishModel dishmodel)
        {

            return await _asyncRepository.AddAsync(dishmodel);

        }

    }
}
