namespace CoffeeShop.BL.Models
{
    public class RecipeInCoffeeMachineModel
    {
        //TODO: Change entities in entities to FK in all  tables!
        public int Id { get; set; }
        public RecipeModel Recipe { get; set; }
        public CoffeeMachineModel CoffeeMachine { get; set; }
    }
}