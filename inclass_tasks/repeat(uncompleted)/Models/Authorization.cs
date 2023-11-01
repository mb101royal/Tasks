using Core.Models;
using DocumentFormat.OpenXml.Spreadsheet;

namespace repeat.Models
{
    public class Authorization
    {
        List<User> users = new List<User>();
        public bool IsLoggedIn { get; set; }
        public void Register(string name, string surname, ref string Username, ref string Password)
        {
            User user = new User();
            user.Name = name;
            user.Surname = surname;
            user.Username = Username;
            user.Password = Password;

            users.Add(user);
            IsLoggedIn = true;

            Console.WriteLine("User registered.");
        }
        public void Login(string Username, string Password)
        {
            /*foreach (var user in users)
            {
                if (user.Username == Username && user.Password == Password)
                {
                    IsLoggedIn = true;
                    Console.WriteLine("You're logged in.");
                    break;
                }
                else
                {
                    continue;
                }
            }*/
        }
        public void Logout()
        {
            if (IsLoggedIn)
            {
                IsLoggedIn = false;
                Console.WriteLine("You're logged out.");
            }
            else
            {
                Console.WriteLine("You're not logged in.");
            }
        }
    }
}
