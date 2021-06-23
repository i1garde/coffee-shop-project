namespace CoffeeShop.BL.Models
{
    public class RecipeInCoffeeMachineModel
    {
        public int Id { get; set; }
        public RecipeModel Recipe { get; set; }
        public CoffeeMachineModel CoffeeMachine { get; set; }
    }
}