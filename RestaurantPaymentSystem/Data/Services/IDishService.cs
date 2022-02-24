using RestaurantPaymentSystem.Data.Models;

namespace RestaurantPaymentSystem.Data.Services
{
    public interface IDishService
    {

        Task<DishModel> GetDishById(int id);

        Task<DishModel> CreateDishModel(DishModel dishmodel);
    }
}
