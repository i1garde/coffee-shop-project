namespace CoffeeShop.DAL.Entities
{
    public class IngredientsInCoffeeMachineEntity : BaseEntity<int>
    {
        public int IngredientId { get; set; }
        public IngredientEntity Ingredient { get; set; }
        public int CoffeeMachineId { get; set; }
        public CoffeeMachineEntity CoffeeMachine { get; set; }
        public float IngredientAmount { get; set; }
        public float IngredientCapacity { get; set; }
    }
}