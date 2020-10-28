namespace FoodOrder.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public virtual User User { get; set; }
        public virtual Meal Meal { get; set; }
        public string Receipt { get; set; }
        public int Sum { get; set; }

    }
}
