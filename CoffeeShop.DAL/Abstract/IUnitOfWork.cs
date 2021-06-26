using System;

namespace CoffeeShop.DAL.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ICoffeeMachineRepository CoffeeMachineRepository { get; }
        IRecipeInCoffeeMachineRepository RecipeInCoffeeMachineRepository { get; }
        IIngredientInCoffeeMachineRepository IngredientInCoffeeMachineRepository { get; }
        IRecipeRepository RecipeRepository { get; }
        IOrderRepository OrderRepository { get; }
        IIngredientRepository IngredientRepository { get; }
        IIngredientInRecipeRepository IngredientInRecipeRepository { get; }

        void Save();
    }
}