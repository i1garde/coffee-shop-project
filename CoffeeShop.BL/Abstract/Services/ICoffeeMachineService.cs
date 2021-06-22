using System;
using System.Collections.Generic;
using CoffeeShop.BL.Models;

namespace CoffeeShop.BL.Abstract.Services
{
    public interface ICoffeeMachineService
    {
        TimeSpan GetTimeToRefreshIngredients(int id, DateTime firstDate, DateTime lastDate);
    }
}