namespace upcasting__downcasting.Models
{
    public abstract class Vehicle
    {
        public decimal Price { get; set; }
        public abstract void Drive();
    }
}
