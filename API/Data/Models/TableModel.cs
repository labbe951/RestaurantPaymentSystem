namespace API.Data.Models
{
    public class TableModel
    {
        public int TableId { get; set; }
        public int TableNumber { get; set; }
        public List<DishModel>? DishModels { get; set; }
    }
}
