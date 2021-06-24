using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.DAL.Entities
{
    public class CoffeeMachineEntity : BaseEntity<int>
    {
        public string Name { get; set; }
        public virtual List<RecipeEntity> Recipes { get; set; }
        public virtual List<OrderEntity> Orders { get; set; }
        public virtual List<IngredientsInCoffeeMachineEntity> Ingredients { get; set; }
        //TODO: Implement Place and Popularity fields
    }
}