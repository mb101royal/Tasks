using indexer__extension.Extensions;
using indexer__extension.Models;

namespace indexer__extension
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region 1:
			Console.WriteLine(ExtensionMethods.IsPrime(127));
			Console.WriteLine(ExtensionMethods.IsPowOfTwo(1));
			#endregion
			#region 2:
			Gallery gallery = new Gallery();

			Car car = new Car();
			car.Name = "Test";
			car.ProducedYear = 1;
			car.Color = "green";

			Car car1 = new Car();
			car1.Name = "Test2";
			car1.ProducedYear = 12;
			car1.Color = "green1";

			gallery.AddCar(car);
			gallery.AddCar(car1);

            gallery[4] = car1;

			Console.WriteLine(gallery[car1.Name]);

            foreach (var item in gallery.Cars) Console.WriteLine(item);
			#endregion
		}
	}
}