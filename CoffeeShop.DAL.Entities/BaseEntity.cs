namespace CoffeeShop.DAL.Entities
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}