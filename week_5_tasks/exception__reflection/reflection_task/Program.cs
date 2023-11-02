using reflection_task.Models;
using System.Reflection;

namespace reflection_task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Assembly assem = typeof(User).Assembly;

			User user = (User)assem.CreateInstance("reflection_task.Models.User");

			Console.WriteLine("Enter name");
			user.GetType().GetProperty("Name").SetValue(user, Console.ReadLine(), null);

			Console.WriteLine("Enter Age");
			user.GetType().GetProperty("Age").SetValue(user, Convert.ToByte(Console.ReadLine()), null);

			if (!(user == null)) Console.WriteLine("Created a {0} object whose value is '{1}'", user.GetType().Name, user);
			else Console.WriteLine("Unable to instantiate a Person object.");

			// ChangeAge side:
			Console.Write("\nEnter new age: ");
			string userInput = Console.ReadLine();

			if (byte.TryParse(userInput, out byte newAge))
			{
				MethodInfo changeAgeMethod = user.GetType().GetMethod("ChangeAge", BindingFlags.Static | BindingFlags.Public);
				object[] parameters = { newAge };
				changeAgeMethod.Invoke(null, parameters);

				Console.WriteLine("Age changed to: " + user.Age);
				Console.WriteLine("Now object of {0} looks like this: '{1}'", user.GetType().Name, user);
			}
			else Console.WriteLine("Invalid input. Please enter a valid age.");
		}
	}
}