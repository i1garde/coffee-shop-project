using System.Collections.Generic;
using System.Linq;
using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Entities;
using CoffeeShop.Mappers.Impl;
using CoffeeShop.Mappers.Abstract;

namespace CoffeeShop.BL.Impl.Services
{
    public class RecipeInCoffeeMachineService : IRecipeInCoffeeMachineService
    {
        private IUnitOfWork _unitOfWork;
        private IRecipeInCoffeeMachineMapper _recipeInCoffeeMachineMapper;
        
        public RecipeInCoffeeMachineService(IUnitOfWork unitOfWork, IRecipeInCoffeeMachineMapper recipeInCoffeeMachineMapper)
        {
            _unitOfWork = unitOfWork;
            _recipeInCoffeeMachineMapper = recipeInCoffeeMachineMapper;
        }
        
        public List<RecipeInCoffeeMachineModel> GetRecipes(int id)
        {
            List<RecipeInCoffeeMachineEntity> temp =
                _unitOfWork.RecipeInCoffeeMachineRepository.GetAllByCoffeeMachineId(id);
            List<RecipeInCoffeeMachineModel> modelsList =
                new List<RecipeInCoffeeMachineModel>();
            for (int i = 0; i < temp.Count; i++)
            {
                modelsList.Add(_recipeInCoffeeMachineMapper.ToModel(temp[i]));
            }
            return modelsList;
        }
    }
}