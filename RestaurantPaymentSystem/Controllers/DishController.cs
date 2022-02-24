using Microsoft.AspNetCore.Mvc;
using RestaurantPaymentSystem.Data.Models;
using RestaurantPaymentSystem.Data.Services;

namespace RestaurantPaymentSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishController : ControllerBase
    {
        private readonly IDishService _dishService;

        public DishController(IDishService dishService)
        {
            _dishService = dishService;
        }

        //[HttpPost]
        //public async Task<ActionResult<DishModel>> CreateDish(DishModel model)
        //{
        //    return await _dishService.CreateDishes();
        //}

        [HttpGet]
        public async Task<DishModel> GetDishById(int id)
        {

            return await _dishService.GetDishById(id);
        }
    }
}
