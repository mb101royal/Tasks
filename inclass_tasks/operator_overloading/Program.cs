using operator_overloading.Models;

namespace operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();

            car1.Price = 253;
            car2.Price = 254;

            Console.WriteLine(car1 > car2);
        }
    }
}