using System;
using CoffeeShop.BL;
using CoffeeShop.BL.Abstract.Services;
using CoffeeShop.BL.Impl.Services;
using CoffeeShop.DAL;
using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Impl;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShop.CLI
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Applicaltion app = new Applicaltion();
            app.Run();
        }
    }
}