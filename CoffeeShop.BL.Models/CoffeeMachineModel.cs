using System.Collections.Generic;

namespace CoffeeShop.BL.Models
{
    public class CoffeeMachineModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RecipeModel> Recipes { get; set; }
        public List<OrderModel> Orders { get; set; }
        public List<IngredientsInCoffeeMachineModel> Ingredients { get; set; }
    }
}