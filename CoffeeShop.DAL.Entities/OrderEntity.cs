using System;

namespace CoffeeShop.DAL.Entities
{
    public class OrderEntity : BaseEntity<int>
    {
        public int CoffeeMachineId { get; set; }
        public CoffeeMachineEntity CoffeeMachine { get; set; }
        public int RecipeId { get; set; }
        public RecipeEntity Recipe { get; set; }
        public DateTime OrderTime { get; set; }
    }
}