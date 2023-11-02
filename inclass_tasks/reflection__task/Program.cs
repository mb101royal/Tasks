using reflection__task.Models;
using System;
using System.Reflection;

namespace reflection__task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assem = typeof(User).Assembly;

            User user = (User)assem.CreateInstance("reflection__task.Models.User");

            Console.WriteLine("Enter name");
            user.GetType().GetProperty("Name").SetValue(user, Console.ReadLine(), null);
            
            Console.WriteLine("Enter Age");
            user.GetType().GetProperty("Age").SetValue(user, Convert.ToByte(Console.ReadLine()), null);

            // TODO: fix this
            user.GetType().GetMethod("ChangeAge");

            if (!(user == null)) Console.WriteLine("Created a {0} object whose value is '{1}'", user.GetType().Name, user);
            else Console.WriteLine("Unable to instantiate a Person object.");
        }
    }
}