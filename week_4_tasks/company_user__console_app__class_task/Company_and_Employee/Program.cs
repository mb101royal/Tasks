using Company_and_Employee.Models;

namespace Company_and_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Wirket");
            Employee employee = new Employee("celil", "celilov");

            char answer;

            do
            {
                Info();
                answer = Convert.ToChar(Console.ReadLine());
                switch (answer)
                {
                    case '1':
                        
                        break;
                    case '2':
                        company.AddUser(new Employee("celil1", "celilov1"));
                        break;
                    case '3':
                        Console.WriteLine("Which user?");
                        company.RemoveUser(Console.ReadLine());
                        break;
                    case '4':
                        /*company.UpdateUser("asda");*/
                        break;
                    case '5':
                        company.GetAllUsers();
                        break;
                    case '6':

                        break;
                    default:
                        Console.WriteLine("Error.");
                        break;
                }
            } while (answer != 'q');
        }

        static void Info()
        {
            Console.WriteLine("1 Create a company");
            Console.WriteLine("2 Create an employee");
            Console.WriteLine("3 Delete employee");
            Console.WriteLine("4 Update employee");
            Console.WriteLine("5 See all employees");
            Console.WriteLine("6 See employee");
        }
    }
}