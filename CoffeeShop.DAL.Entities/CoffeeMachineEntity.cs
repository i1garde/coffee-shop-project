using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.DAL.Entities
{
    public class CoffeeMachineEntity : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}