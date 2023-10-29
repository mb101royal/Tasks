using vehicle.Interfaces;

namespace vehicle.Models;
public class Car : Vehicle, IEngine, IWheel, ITransmission
{
	public int HorsePower { get; set; }
	public int TankSize { get; set; }
	public int CurrentOil { get; set; }
	public string FuelType { get; set; }
	public float WheelThickness { get; set; }
	public string TransmissionKind { get; set; }
	public int DoorCount { get; set; }
	public string WinCode { get; set; }

	public override float AverageSpeed()
	{
		return DrivePath / DriveTime;
	}

	public float RemainOilAmount()
	{
		if ((CurrentOil > 0 && TankSize > 0) && TankSize >= CurrentOil)
		{
			float remainingOilPercentage = ((float)CurrentOil / TankSize) * 100;
			return remainingOilPercentage;
		}
		else
		{
			Console.WriteLine("Invalid oil data. Cannot calculate remaining oil amount.");
			return 0;
		}
	}
	/*public bool IsNegative(int number)
	{
		bool result = true;
		if (number >= 0)
		{
			result = false;
			return result;
		}
		return result;
	}*/
}