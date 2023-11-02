using exception_task.Models;
using exception_task.Exceptions;

namespace exception_task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			User user = new User();

		Name:
			try
			{
				Console.WriteLine("Enter Name");
				user.Name = Console.ReadLine();
			}
			catch (InvalidNameException ex)
			{
				Console.WriteLine(ex.Message);
				goto Name;
			}
		Age:
			try
			{
				Console.WriteLine("Enter Age");
				user.Age = Convert.ToByte(Console.ReadLine());
			}
			catch (InvalidAgeException ex)
			{
				Console.WriteLine(ex.Message);
				goto Age;
			}
		Phone:
			try
			{
				Console.WriteLine("Enter Phone");
				user.PhoneNumber = Console.ReadLine(); // +000-00-000-00-00
			}
			catch (InvalidPhoneFormat ex)
			{
				Console.WriteLine(ex.Message);
				goto Phone;
			}
		Password:
			try
			{
				Console.WriteLine("Enter Password");
				user.Password = Console.ReadLine();
			}
			catch (PasswordException ex)
			{
				Console.WriteLine(ex.Message);
				goto Password;
			}

			Console.WriteLine(user);
		}
	}
}