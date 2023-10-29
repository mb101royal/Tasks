using vehicle.Interfaces;

namespace vehicle.Models;
public class Bicycle : Vehicle, IWheel
{
	public float WheelThickness { get; set; }
	public string PedalKind { get; set; }

	public override float AverageSpeed()
	{
		return DrivePath / DriveTime;
	}
}