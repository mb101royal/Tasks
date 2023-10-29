namespace vehicle.Models;
public abstract class Vehicle
{
	public float DriveTime { get; set; }
	public float DrivePath { get; set; }

	public abstract float AverageSpeed();
}