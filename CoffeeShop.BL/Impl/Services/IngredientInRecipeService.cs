using System.Collections.Generic;
using System.Linq;
using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.Mappers.Abstract;
using CoffeeShop.Mappers.Impl;

namespace CoffeeShop.BL.Impl.Services
{
    public class IngredientInRecipeService : IIngredientInRecipeService
    {
        private IUnitOfWork _unitOfWork;
        private IIngredientInRecipeMapper _ingredientInRecipeMapper;
        public IngredientInRecipeService
            (IUnitOfWork unitOfWork, IIngredientInRecipeMapper ingredientInRecipeMapper)
        {
            _unitOfWork = unitOfWork;
            _ingredientInRecipeMapper = ingredientInRecipeMapper;
        }
        public List<IngredientInRecipeModel> GetIngredients(int id)
        {
            return _unitOfWork.IngredientInRecipeRepository
                .GetAllByRecipeId(id)
                .Select(x => _ingredientInRecipeMapper.ToModel(x)).ToList();
        }
    }
}