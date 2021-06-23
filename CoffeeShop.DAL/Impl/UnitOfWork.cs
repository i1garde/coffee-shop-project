using System;
using CoffeeShop.DAL.Abstract;

namespace CoffeeShop.DAL.Impl
{
    public class UnitOfWork : IUnitOfWork
    {
        private CoffeeShopDBContext _context;
        private bool isDisposed;
        
        public UnitOfWork(CoffeeShopDBContext context,
            ICoffeeMachineRepository coffeeMachineRepository,
            IRecipeInCoffeeMachineRepository recipeInCoffeeMachineRepository,
            IIngredientInCoffeeMachineRepository ingredientInCoffeeMachineRepository,
            IRecipeRepository recipeRepository,
            IOrderRepository orderRepository,
            IIngredientRepository ingredientRepository,
            IIngredientInRecipeRepository ingredientInRecipeRepository)
        {
            this._context = context;
            this.isDisposed = false;
            CoffeeMachineRepository = coffeeMachineRepository;
            RecipeInCoffeeMachineRepository = recipeInCoffeeMachineRepository;
            IngredientInCoffeeMachineRepository = ingredientInCoffeeMachineRepository;
            RecipeRepository = recipeRepository;
            OrderRepository = orderRepository;
            IngredientRepository = ingredientRepository;
            IngredientInRecipeRepository = ingredientInRecipeRepository;
        }
        ~UnitOfWork()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if(isDisposed) { return; }
            if(disposing) { _context.Dispose(); }
            isDisposed = true;
        }

        public ICoffeeMachineRepository CoffeeMachineRepository { get; private set; }
        public IRecipeInCoffeeMachineRepository RecipeInCoffeeMachineRepository { get; private set; }
        public IIngredientInCoffeeMachineRepository IngredientInCoffeeMachineRepository { get; private set; }
        public IRecipeRepository RecipeRepository { get; private set; }
        public IOrderRepository OrderRepository { get; private set; }
        public IIngredientRepository IngredientRepository { get; private set; }
        public IIngredientInRecipeRepository IngredientInRecipeRepository { get; private set; }
        
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}