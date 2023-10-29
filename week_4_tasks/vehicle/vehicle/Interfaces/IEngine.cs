namespace vehicle.Interfaces;
public interface IEngine
{
	int HorsePower { get; set; }
	int TankSize { get; set; }
	int CurrentOil { get; set; }
	string FuelType { get; set; }

	float RemainOilAmount();
}