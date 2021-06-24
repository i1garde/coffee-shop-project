using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.DAL.Entities
{
    public abstract class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}