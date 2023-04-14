namespace Restaurant.Product.Beverage
{
    public abstract class Beverage : Product
    {
        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            Milliliters = milliliters;
        }
        public virtual double Milliliters { get; private set; }
    }
}
