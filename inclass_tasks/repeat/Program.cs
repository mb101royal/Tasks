using Core.Models;

namespace repeat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte answer;
            string name, surname, username, password;
            while (true)
            {
                Console.WriteLine("Enter a name:");
                name = Console.ReadLine();
                if (ProperName(name)) break;
                else continue;
            }
            
            surname = Console.ReadLine();
            username = Console.ReadLine();
            password = Console.ReadLine();



            while (true)
            {
                if (Username.Length > 4)
                {
                    _username = value;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong username. Try Again");
                    value = Console.ReadLine();
                }
            }








            do
            {
                Info();
                answer = Convert.ToByte(Console.ReadLine());
                if(IsLoggedIn)
                    switch (answer)
                    {
                        case 1:

                            break;
                        case 2:
                            Register();
                            break;
                        case 3:
                            Logout();
                            break;
                        default:
                            Console.WriteLine("error.");
                            break;
                    }
                else
                {
                    Console.WriteLine("1 - Logout");
                    if (answer == 1)
                    {
                        .Logout();
                    }
                }
            } while (answer != 0);

        }
        public static void GetUsers(ref List<User> users)
        {
            if (users != null)
            {
                foreach (var user in users) Console.WriteLine(user);
            }
            else Console.WriteLine("users is null.");
        }
        public static List<User> AddUser(ref List<User> users, User user)
        {
            if (users != null) users.Add(user);
            return users;
        }
        static void Info()
        {
            Console.WriteLine("1 - Login");
            Console.WriteLine("2 - Register");
            Console.WriteLine("3 - Logout");
        }
    }
}
