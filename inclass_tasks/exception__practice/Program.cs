using exception__practice.Exceptions;
using exception__practice.Models;

namespace exception__practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region exceptions:
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
                user.PhoneNumber = Console.ReadLine();
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
            #endregion
            #region reflections:

            #endregion
        }
    }
}