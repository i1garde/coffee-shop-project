namespace CoffeeShop.DAL.Entities
{
    public class RecipeInCoffeeMachineEntity : BaseEntity<int>
    {
        public int RecipeId { get; set; }
        public RecipeEntity Recipe { get; set; }
        public int CoffeeMachineId { get; set; }
        public CoffeeMachineEntity CoffeeMachine { get; set; }
    }
}