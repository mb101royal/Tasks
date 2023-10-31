using static__extension.Extensions;
using static__extension.Models;

namespace static__extension
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student student = new();

			byte answer;
			do
			{
				Info();
				answer = Convert.ToByte(Console.ReadLine());
				if ((answer >= 0 && answer < 4) )
				{
					switch (answer)
					{
						case 1:
							Console.WriteLine("Enter name:");
							student.Name = Console.ReadLine();
							Console.WriteLine("Enter surname:");
							student.Surname = Console.ReadLine();
							Console.WriteLine("Enter the age:");
							student.Age = Convert.ToByte(Console.ReadLine());
							Console.WriteLine("Enter the group number:");
							student.GroupNo = Console.ReadLine();
							break;
						case 2:
							Console.WriteLine($"Is there a group number?: {Extension.CheckGroupNo(student.GroupNo)}, group number: {student.GroupNo}");
							break;
						case 3:
							Console.WriteLine($"Does fullname typed correctly?: {Extension.CheckFullName(student.FullName)}, Fullname: {student.FullName}");
							break;
					}
				}
				else
				{
                    Console.WriteLine("Your options: 0, 1, 2, 3!");
					continue;
                }
			} while (answer != 0);
		}

		static void Info()
		{
			Console.WriteLine("0 - Exit");
			Console.WriteLine("1 - Create a student");
			Console.WriteLine("2 - CheckGroupNo method");
			Console.WriteLine("3 - CheckFullName method.");
		}
	}
}