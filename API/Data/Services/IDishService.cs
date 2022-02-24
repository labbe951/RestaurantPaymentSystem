using API.Data.Models;

namespace API.Data.Services
{
    public interface IDishService
    {

        Task<DishModel> GetDishById(int id);

        Task<DishModel> CreateDishModel(DishModel dishmodel);
    }
}
