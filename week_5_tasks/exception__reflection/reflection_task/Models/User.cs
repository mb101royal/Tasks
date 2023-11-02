namespace reflection_task.Models
{
	internal class User
	{
		int _id;
		public int Id { get; }
		string _name;
		static byte _age;
		public string Name { get => _name; set { if (value.Length >= 3 && value.Length <= 30) _name = value; } }
		public byte Age { get => _age; set { if (value > 0) _age = value; } }

		public User()
		{
			_id++;
			Id = _id;
		}
		public static void ChangeAge(byte age)
		{
			_age = age;
		}

		public override string ToString()
		{
			return $"Name: {Name}, Age: {Age}.";
		}
	}
}
