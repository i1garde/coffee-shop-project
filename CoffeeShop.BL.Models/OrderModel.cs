using System;

namespace CoffeeShop.BL.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int CoffeeMachineId { get; set; }
        public CoffeeMachineModel CoffeeMachine { get; set; }
        public int RecipeId { get; set; }
        public RecipeModel Recipe { get; set; }
        public DateTime OrderTime { get; set; }
    }
}