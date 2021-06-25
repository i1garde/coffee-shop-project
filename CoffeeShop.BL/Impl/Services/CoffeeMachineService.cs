using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Impl;
using CoffeeShop.Mappers.Impl;
using CoffeeShop.Mappers.Abstract;

namespace CoffeeShop.BL.Impl.Services
{
    public class CoffeeMachineService : ICoffeeMachineService
    {
        private IUnitOfWork _unitOfWork;
        private ICoffeeMachineMapper _coffeeMachineMapper;
        private IOrderService _orderService;
        private IRecipeInCoffeeMachineService _recipeInCoffeeMachineService;
        private IIngredientInCoffeeMachineService _ingredientInCoffeeMachineService;
        private IIngredientService _ingredientService;
        private const int AverageCoffeeDaySales = 5;
        public CoffeeMachineService
            (IUnitOfWork unitOfWork,
            ICoffeeMachineMapper coffeeMachineMapper,
            IOrderService orderService,
            IRecipeInCoffeeMachineService recipeInCoffeeMachineService,
            IIngredientInCoffeeMachineService ingredientInCoffeeMachineService,
            IIngredientService ingredientService)
        {
            _unitOfWork = unitOfWork;
            _coffeeMachineMapper = coffeeMachineMapper;
            _orderService = orderService;
            _recipeInCoffeeMachineService = recipeInCoffeeMachineService;
            _ingredientInCoffeeMachineService = ingredientInCoffeeMachineService;
            _ingredientService = ingredientService;
        }

        public void Add(CoffeeMachineModel coffeeMachineModel)
        {
            _unitOfWork.CoffeeMachineRepository.Add(_coffeeMachineMapper.ToEntity(coffeeMachineModel));
            _unitOfWork.Save();
        }

        public List<CoffeeMachineModel> GetAll()
        {
            List<CoffeeMachineModel> coffeeMachineModels =
                new List<CoffeeMachineModel>();
            foreach (var i in _unitOfWork.CoffeeMachineRepository.GetAll())
            {
                coffeeMachineModels.Add(_coffeeMachineMapper.ToModel(i));
            }
            return coffeeMachineModels;
        }
        ///////////////////////
        
//Main method
        public List<int> GetTimeToRefreshIngredients
            (CoffeeMachineModel coffeeMachine, DateTime start, DateTime end)
        {
            List<RecipeInCoffeeMachineModel> recipeInCoffeeMachine = 
                _recipeInCoffeeMachineService.GetRecipes(coffeeMachine.Id);
            int recipesInCoffeMachine = recipeInCoffeeMachine.Count();

            List<IngredientInCoffeeMachineModel> startingState =
                _ingredientInCoffeeMachineService.GetIngredients(coffeeMachine.Id);

            List<float> startIngredientsAmount = new List<float>();
            for (int i = 0; i < startingState.Count; i++)
            {
                startIngredientsAmount.Add(startingState[i].IngredientAmount);
            }

            Random random = new Random();
            int ResultCoffeeSales = Convert.ToInt32(CountResultCoffeeSales(coffeeMachine, start, end));

            for (int i = 0; i < ResultCoffeeSales; i++)
            {
                int randomValue = random.Next(1, recipesInCoffeMachine + 1);
                TimeSpan timeSpan = end - start;
                TimeSpan newSpan = new TimeSpan(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);
                DateTime newDate = start + newSpan;
                //Eject ingredients
                if (_ingredientInCoffeeMachineService.EjectIngredient(coffeeMachine,
                    recipeInCoffeeMachine[randomValue - 1]))
                {
                    _orderService.CreateOrder(newDate, recipeInCoffeeMachine[randomValue - 1]);
                }
            }
            //
            List<IngredientInCoffeeMachineModel> currState =
                _ingredientInCoffeeMachineService.GetIngredients(coffeeMachine.Id);
            List<int> result = new List<int>();
            for (int i = 0; i < _ingredientService.GetAll().Count; i++)
            {
                float difference = startIngredientsAmount[i] - currState[i].IngredientAmount;
                float diffPerDay = difference / GetTimeSpanDays(start, end);
                float resAmount = currState[i].IngredientAmount;
                int counter = 0;
                while (resAmount >= 0)
                {
                    counter++;
                    resAmount -= diffPerDay;
                }
                result.Add(counter);
            }
            return result;
        }
        //Main method^^
        private float CountResultCoffeeSales(CoffeeMachineModel coffeeMachine, DateTime start, DateTime end)
        {
            TimeSpan daysSpan = end.Subtract(start);
            float result = Convert.ToSingle(AverageCoffeeDaySales) * 
                           coffeeMachine.PlaceCoef * 
                           coffeeMachine.PopularityCoef *
                           daysSpan.Days;
            return result;
        }

        private int GetTimeSpanDays(DateTime start, DateTime end)
        {
            TimeSpan tempDataTime = end.Subtract(start);
            return tempDataTime.Days;
        }
    }
}