namespace upcasting__downcasting.Models
{
    internal class Bus : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Bus is driving.");
        }
    }
}
