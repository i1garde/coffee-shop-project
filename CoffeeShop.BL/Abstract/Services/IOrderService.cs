using System;
using System.Collections.Generic;
using CoffeeShop.BL.Models;

namespace CoffeeShop.BL.Abstract.Services
{
    public interface IOrderService
    {
        void Add(OrderModel orderModel);
        void CreateOrder(DateTime date, RecipeInCoffeeMachineModel recipe);
        List<OrderModel> GetAllOrders();
    }
}