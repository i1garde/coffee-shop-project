using System;
using System.Collections.Generic;
using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.BL.Models;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.Mappers.Impl;
using CoffeeShop.Mappers.Abstract;

namespace CoffeeShop.BL.Impl.Services
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork _unitOfWork;
        private IOrderMapper _orderMapper;
        
        public OrderService(IUnitOfWork unitOfWork, IOrderMapper orderMapper)
        {
            _unitOfWork = unitOfWork;
            _orderMapper = orderMapper;
        }
        
        public void Add(OrderModel orderModel)
        {
            _unitOfWork.OrderRepository.Add(_orderMapper.ToEntity(orderModel));
            _unitOfWork.Save();
        }
        
        public void CreateOrder(DateTime date, RecipeInCoffeeMachineModel recipe)
        {
            OrderModel order = new OrderModel(recipe.Recipe, date);
            _unitOfWork.OrderRepository.Add(_orderMapper.ToEntity(order));
            _unitOfWork.Save();
        }
        
        public List<OrderModel> GetAllOrders()
        {
            List<OrderModel> orderModels =
                new List<OrderModel>();
            foreach (var i in _unitOfWork.OrderRepository.GetAll())
            {
                orderModels.Add(_orderMapper.ToModel(i));
            }
            return orderModels;
        }
    }
}