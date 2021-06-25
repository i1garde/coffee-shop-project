using System;

namespace CoffeeShop.BL.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public RecipeModel Recipe { get; set; }
        public DateTime OrderTime { get; set; }

        public OrderModel()
        {
            
        }
        public OrderModel(RecipeModel recipe, DateTime date)
        {
            Recipe = recipe;
            OrderTime = date;
        }
    }
}