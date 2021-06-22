using System;
using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.DAL;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Impl;

namespace CoffeeShop.BL.Impl.Services
{
    public class CoffeeMachineService : ICoffeeMachineService
    {
        private IUnitOfWork _unitOfWork;
        
        public CoffeeMachineService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public TimeSpan GetTimeToRefreshIngredients(int id, DateTime firstDate, DateTime lastDate)
        {
            TimeSpan result = new TimeSpan();
            return result;
        }
    }
}