using Company_and_Employee.Models;

namespace Company_and_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Shirket");

            char answer;

            do
            {
                Info();
                answer = Convert.ToChar(Console.ReadLine());
                switch (answer)
                {
                    case '1':
                        company.CreateNewCompany();
						break;
                    case '2':
                        Console.WriteLine("Add Name and then Surname(press Enter for each):");
                        company.AddUser(new Employee(Console.ReadLine(), Console.ReadLine()));
                        break;
                    case '3':
                        Console.WriteLine("Which user you want to remove(Enter username)?");
                        company.RemoveUser(Console.ReadLine());
                        break;
                    case '4':
						Console.WriteLine("Which user info you want to modify(Enter username)?");
						company.UpdateUser(Console.ReadLine());
                        break;
                    case '5':
                        company.GetAllUsers();
                        break;
                    case '6':
                        Console.WriteLine("Username of the user you want to look for:");
						company.GetUser(Console.ReadLine());
						break;
                    default:
                        Console.WriteLine("Error.");
                        break;
                }
            } while (answer != 'q');
        }

        static void Info()
        {
            Console.WriteLine("1. Create a new company.");
            Console.WriteLine("2. Create an employee.");
            Console.WriteLine("3. Delete employee.");
            Console.WriteLine("4. Update employee.");
            Console.WriteLine("5. See all employees.");
            Console.WriteLine("6. See employee.");
        }
    }
}