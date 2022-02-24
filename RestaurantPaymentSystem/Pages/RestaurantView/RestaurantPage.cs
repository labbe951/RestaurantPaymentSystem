using Microsoft.AspNetCore.Components;
using RestaurantPaymentSystem.Data.Models;
using RestaurantPaymentSystem.Data.Services;

namespace RestaurantPaymentSystem.Pages.RestaurantView
{
    public partial class RestaurantPage : ComponentBase
    {
        [Inject]
        public IDishService DishService { get; set; }
        [Inject]
        public ITableService TableService { get; set; }

        public DishModel SelectedDish { get;set; } = new DishModel();
        public DishModel CreatedDishForTable { get; set; } = new DishModel();
        public TableModel SelectedTable { get; set; } = new TableModel();

        public async Task SelectDish(int id)
        {
            SelectedDish = await DishService.GetDishById(id);
            SelectedDish.DishId = 0;
            CreatedDishForTable = await DishService.CreateDishModel(SelectedDish);

        }

        public async Task SelectTable(int id)
        {
            SelectedTable = await TableService.GetTableById(id);
        }

        public async Task AddDishToTable()
        {
            if (SelectedTable.DishModels == null)
            {
                SelectedTable.DishModels = new List<DishModel>();
            }
            if(CreatedDishForTable != null)
            {
                SelectedTable.DishModels.Add(CreatedDishForTable);
                await TableService.UpdateTable(SelectedTable);
            }
            
        }
    }
}
