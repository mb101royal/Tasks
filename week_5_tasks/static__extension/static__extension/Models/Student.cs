namespace static__extension.Models
{
	internal class Student
	{
		static int _id;
		int Id { get; }
		string _name { get; set; }
		string _surname { get; set; }
        byte _age { get; set; }
        string _fullname { get; set; }
		public string Name
		{
			get => _name;
			set
			{
				while (true)
				{
					value = value.Trim();
					if (value.Length >= 3 && CustomIsDigit(value))
					{
						_name = CustomCapitalize(value);
						break;
					}
					else
					{
						Console.WriteLine("Wrong name. Try again");
						value = Console.ReadLine();
					}
				}
			}
		}
		public string Surname
		{
			get => _surname;
			set
			{
				
				while (true)
				{
					value = value.Trim();
					if (value.Length > 4 && CustomIsDigit(value))
					{
						_surname = CustomCapitalize(value);
						break;
					}
					else
					{
                        Console.WriteLine("Wrong surname. Again please.");
						value = Console.ReadLine();
					}
				}
			}
		}
		public string FullName { get => $"{_name} {_surname}"; }
		public byte Age
		{
			get => _age;
			set
			{
				while (true)
				{
					if (value <= 0 || value > 150)
					{
						Console.WriteLine("The age isn't correct. Try again.");
						value = Convert.ToByte(Console.ReadLine());
					}
					else
					{
						_age = value;
						break;
					}
				}
			}
		}
		string _groupNo;
		public string GroupNo
		{
			get => _groupNo;
			set 
			{
				while (true)
				{
					if (value.Length == 4 && Char.IsLetter(value[0]) && value.Substring(1).All(char.IsDigit))
					{
						_groupNo = value.ToUpper();
						break;
					}
					else
					{
						Console.WriteLine("Group Number isn't correct. Retry.");
						value = Console.ReadLine();
					}
				}
			} 
		}

        public Student()
        {
			++_id;
			Id = _id;
			_fullname = _name + " " + _surname;
        }

		public bool CustomIsDigit(string value)
		{
			bool result = true;

			for (int i = 0; i < value.Length; i++) if (char.IsDigit(value[i])) return result = false;

			return result;
		}

		public string CustomCapitalize(string value)
		{
			return value.Substring(0, 1).ToUpper() + value.Substring(1);
		}
	}
}
