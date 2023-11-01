namespace indexer__extension.Models
{
	public class Gallery
	{
		public string Name { get; set; }
		public Car[] Cars = new Car[0];

		public void AddCar(Car car)
		{
			Array.Resize(ref Cars, Cars.Length + 1);
			Cars[Cars.Length - 1] = car;
		}

		// indexers:
        public Car this[int index]
		{
			get => Cars[index];
			set
			{
				if (index >= 0 && index < Cars.Length) Cars[index] = value;
				else Console.WriteLine("Wrong index. Reverting...\n");
            }
		}
		public bool this[string name]
		{
			get
			{
				for (int i = 0; i < Cars.Length; i++) if (name == Cars[i].Name) return true;
				return false;
			}
		}
	}
}
