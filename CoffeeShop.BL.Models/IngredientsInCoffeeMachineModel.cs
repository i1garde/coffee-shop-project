﻿namespace CoffeeShop.BL.Models
{
    public class IngredientsInCoffeeMachineModel
    {
        public int Id { get; set; }
        public IngredientModel Ingredient { get; set; }
        public CoffeeMachineModel CoffeeMachine { get; set; }
        public float IngredientAmount { get; set; }
        public float IngredientCapacity { get; set; }
    }
}