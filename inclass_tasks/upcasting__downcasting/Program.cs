using upcasting__downcasting.Models;

namespace upcasting__downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Car();
            Vehicle myBus = new Bus();

            // is
            if (myCar is Car) myCar = (Car)myCar;
            else Console.WriteLine("Nese duz getmedi.");
            if (myBus is Bus) myBus = (Bus)myBus;
            else Console.WriteLine("Nese duz getmedi.");

            // as
            Car myNewCar = myCar as Car;
            Bus myNewBus= myBus as Bus;

            if (myNewCar != null) Console.WriteLine("Good.");
            else Console.WriteLine("Bad.");

            if (myNewBus != null) Console.WriteLine("Good.");
            else Console.WriteLine("Bad.");

            // invoking methods
            myCar.Drive();
            myBus.Drive();
        }
    }
}