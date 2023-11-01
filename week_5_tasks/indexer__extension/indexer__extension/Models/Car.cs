namespace indexer__extension.Models
{
	public class Car
	{
        public string Name { get; set; }
        public string Color { get; set; }
        public int ProducedYear { get; set; }

		public override string ToString()
		{
			return $"Name: {Name}, color: {Color}, Produced year: {ProducedYear}";	
		}
	}
}
