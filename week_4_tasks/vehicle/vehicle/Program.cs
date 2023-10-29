using vehicle.Models;

namespace vehicle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 10 dene vehicle yaratmaq olacaq, daha cox lazimdirsa sayi artirin:
			Vehicle[] vehicles = new Vehicle[10]; 

			int currentIndex = 0;
			byte choice;

			do
			{
				Console.WriteLine("Enter your choice:");
				Console.WriteLine("1 - Create a new Car");
				Console.WriteLine("2 - Create a new Bicycle");
				Console.WriteLine("3 - Create a new Plane");
				Console.WriteLine("4 - Print all Vehicles");
				Console.WriteLine("5 - Remove a Vehicle");

				choice = byte.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Car car = new Car();
						Console.WriteLine("Enter HorsePower:");
						car.HorsePower = int.Parse(Console.ReadLine());
						Console.WriteLine("Enter TankSize:");
						car.TankSize = int.Parse(Console.ReadLine());
						Console.WriteLine("Enter CurrentOil:");
						car.CurrentOil = int.Parse(Console.ReadLine());
						Console.WriteLine("Enter FuelType:");
						car.FuelType = Console.ReadLine();
						Console.WriteLine("Enter Wheel Thickness:");
						car.WheelThickness = float.Parse(Console.ReadLine());
						Console.WriteLine("Enter TransmissionKind:");
						car.TransmissionKind = Console.ReadLine();
						Console.WriteLine("Enter DoorCount:");
						car.DoorCount = int.Parse(Console.ReadLine());
						Console.WriteLine("Enter WinCode:");
						car.WinCode = Console.ReadLine();
						vehicles[currentIndex] = car;
						currentIndex++;
						break;

					case 2:
						Bicycle bicycle = new Bicycle();
						Console.WriteLine("Enter Wheel Thickness:");
						bicycle.WheelThickness = float.Parse(Console.ReadLine());
						Console.WriteLine("Enter PedalKind:");
						bicycle.PedalKind = Console.ReadLine();
						vehicles[currentIndex] = bicycle;
						currentIndex++;
						break;

					case 3:
						Plane plane = new Plane();
						Console.WriteLine("Enter HorsePower:");
						plane.HorsePower = int.Parse(Console.ReadLine());
						Console.WriteLine("Enter TankSize:");
						plane.TankSize = int.Parse(Console.ReadLine());
						Console.WriteLine("Enter CurrentOil:");
						plane.CurrentOil = int.Parse(Console.ReadLine());
						Console.WriteLine("Enter FuelType:");
						plane.FuelType = Console.ReadLine();
						Console.WriteLine("Enter TransmissionKind:");
						plane.TransmissionKind = Console.ReadLine();
						Console.WriteLine("Enter WingLength:");
						plane.WingLength = float.Parse(Console.ReadLine());
						vehicles[currentIndex] = plane;
						currentIndex++;
						break;

					case 4:
						Console.WriteLine("Printing all Vehicles:");
						for (int i = 0; i < currentIndex; i++)
						{
							Console.WriteLine($"{i + 1}. {vehicles[i].GetType().Name}");
						}
						break;

					case 5:
						Console.WriteLine("Enter the index of the Vehicle to remove:");
						int indexToRemove = int.Parse(Console.ReadLine()) - 1;
						if (indexToRemove >= 0 && indexToRemove < currentIndex)
						{
							vehicles[indexToRemove] = null;
							for (int i = indexToRemove; i < currentIndex - 1; i++)
							{
								vehicles[i] = vehicles[i + 1];
							}
							currentIndex--;
							Console.WriteLine("Vehicle removed successfully.");
						}
						else
						{
							Console.WriteLine("Invalid index.");
						}
						break;

					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}     
			} while (choice != 0);
		}
	}
}