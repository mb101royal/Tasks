using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
	internal class User
	{
		public string Username;
		public string Password;
		public bool IsLoggedIn;

		public User(string username, string password)
		{
			Username = username;
			Password = password;
			IsLoggedIn = false;
		}

		public void Login(string username, string password)
		{
			if (IsLoggedIn) Console.WriteLine("Istifadeci onceden hesaba daxil olub.");
			else if (username == Username && password == Password)
			{
				IsLoggedIn = true;
				Console.WriteLine("Istifadeci hesaba daxil oldu.");
			}
			else Console.WriteLine("Invalid username ve ya password. Yeniden cehd edin.");
		}
		public void Logout()
		{
			if (IsLoggedIn)
			{
				IsLoggedIn = false;
				Console.WriteLine("Istifadeci hesabdan cixis etdi.");
			}
			else Console.WriteLine("Istifadeci hesaba giris etmeyib.");
		}
	}
}
