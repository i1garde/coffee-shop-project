using System.Collections.Generic;
using System.Linq;
using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;
using CoffeeShop.Mappers.Abstract;
using CoffeeShop.Mappers.Impl;

namespace CoffeeShop.BL.Impl.Services
{
    public class IngredientInCoffeeMachineService : IIngredientInCoffeeMachineService
    {
        private IUnitOfWork _unitOfWork;
        private IIngredientInCoffeeMachineMapper _ingredientInCoffeeMachineMapper;
        private IIngredientInRecipeService _ingredientInRecipeService;
        public IngredientInCoffeeMachineService
            (IUnitOfWork unitOfWork,
            IIngredientInCoffeeMachineMapper ingredientInCoffeeMachineMapper,
            IIngredientInRecipeService ingredientInRecipeService)
        {
            _unitOfWork = unitOfWork;
            _ingredientInCoffeeMachineMapper = ingredientInCoffeeMachineMapper;
            _ingredientInRecipeService = ingredientInRecipeService;
        }
        
        public List<IngredientInCoffeeMachineModel> GetIngredients(int id)
        {
            return _unitOfWork.IngredientInCoffeeMachineRepository
                .GetAllByCoffeeMachineId(id)
                .Select(x => _ingredientInCoffeeMachineMapper.ToModel(x)).ToList();
        }

        public bool EjectIngredient
            (CoffeeMachineModel coffeeMachineModel, RecipeInCoffeeMachineModel recipeInCoffeeMachine)
        {
            List<IngredientInCoffeeMachineModel> ingredientInCoffeeMachine = 
                GetIngredients(coffeeMachineModel.Id);
            List<IngredientInRecipeModel> ingredientInRecipe =
                _ingredientInRecipeService.GetIngredients(recipeInCoffeeMachine.Recipe.Id);
            for (int i = 0; i < ingredientInRecipe.Count; i++)
            {
                if (ingredientInCoffeeMachine[i].IngredientAmount - ingredientInRecipe[i].IngredientAmount > 0)
                {
                    ingredientInCoffeeMachine[i].IngredientAmount -= ingredientInRecipe[i].IngredientAmount;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}