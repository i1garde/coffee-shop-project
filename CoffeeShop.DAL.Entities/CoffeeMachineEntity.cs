using System.Collections.Generic;

namespace CoffeeShop.DAL.Entities
{
    public class CoffeeMachineEntity : BaseEntity<int>
    {
        public string Name { get; set; }
        public List<RecipeEntity> Recipes { get; set; }
        public List<OrderEntity> Orders { get; set; }
        public List<IngredientsInCoffeeMachineEntity> Ingredients { get; set; }
        //TODO: Implement Place and Popularity fields
    }
}