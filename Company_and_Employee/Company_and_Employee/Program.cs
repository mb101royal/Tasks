using Company_and_Employee.Models;

namespace Company_and_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Wirket");
            Employee employee = new Employee(15, "celil", "celilov");

            employee.GetInfo();



            /*Console.WriteLine("1 Create a company");
            Console.WriteLine("2 Create an employee");
            Console.WriteLine("3 Delete employee");
            Console.WriteLine("4 Update employee");
            Console.WriteLine("5 See all employees");
            Console.WriteLine("6 See employee");

            char answer = Convert.ToChar(Console.ReadLine());

            switch (answer)
            {
                case '1':

                    break;
                case '2':

                    break;
                case '3':

                    break;
                case '4':

                    break;
                case '5':

                    break;
                case '6':

                    break;
                default:
                    Console.WriteLine("Exited.");
                    break;
            }*/
        }
    }
}