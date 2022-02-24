using API.Data.Models;
using API.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
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
