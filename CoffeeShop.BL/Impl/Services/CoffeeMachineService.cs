using System;
using System.Collections.Generic;
using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.BL.Models;
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

        public List<CoffeeMachineModel> GetAll()
        {
            //_unitOfWork.CoffeeMachineRepository.GetAll()
            return null;
        }

        public TimeSpan GetTimeToRefreshIngredients(int id, DateTime firstDate, DateTime lastDate)
        {
            TimeSpan result = new TimeSpan();
            return result;
        }
    }
}