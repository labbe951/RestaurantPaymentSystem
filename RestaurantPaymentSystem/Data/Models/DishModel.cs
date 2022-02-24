namespace RestaurantPaymentSystem.Data.Models
{
    public class DishModel
    {
        public int DishId { get; set; }
        public string? DishName { get; set; }
        public double DishPrice { get; set; }

        public TableModel? Table { get; set; }
    }
}
