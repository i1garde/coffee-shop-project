using System.Collections.Generic;
using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.Mappers.Abstract;
using CoffeeShop.Mappers.Impl;

namespace CoffeeShop.BL.Impl.Services
{
    public class IngredientService : IIngredientService
    {
        private IUnitOfWork _unitOfWork;
        private IIngredientMapper _ingredientMapper;
        public IngredientService(IUnitOfWork unitOfWork, IIngredientMapper ingredientMapper)
        {
            _unitOfWork = unitOfWork;
            _ingredientMapper = ingredientMapper;
        }
        public void Add(IngredientModel ingredientModel)
        {
            _unitOfWork.IngredientRepository.Add(_ingredientMapper.ToEntity(ingredientModel));
            _unitOfWork.Save();
        }

        public List<IngredientModel> GetAll()
        {
            List<IngredientModel> ingredients =
                new List<IngredientModel>();
            foreach (var i in _unitOfWork.IngredientRepository.GetAll())
            {
                ingredients.Add(_ingredientMapper.ToModel(i));
            }
            return ingredients;
        }
    }
}