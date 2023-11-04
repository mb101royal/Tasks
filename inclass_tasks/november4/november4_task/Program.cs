using november4_task.Exceptions;
using november4_task.Models;
using System.Numerics;

namespace november4_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            Employee employee = new();

            byte choice;

            do
            {
                Info();
                choice = Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employee = new Employee();

                        Console.WriteLine("Name:");
                        employee.Name = Console.ReadLine();

                        Console.WriteLine("Surname:");
                        employee.Surname = Console.ReadLine();

                        Console.WriteLine("Age:");
                        employee.Age = Convert.ToByte(Console.ReadLine());

                    retry:
                        Console.WriteLine("Gender(1 - male, 2 - female, 3 - other):");
                        int answer = Convert.ToInt32(Console.ReadLine()) ;

                        if (answer < 4 && answer > 0)
                            employee.Gender = (Genders)answer;
                        else
                        {
                            Console.WriteLine("Gender is incorrect.");
                            goto retry;
                        }

                        Console.WriteLine("Position:");
                        employee.Position = Console.ReadLine();

                        Console.WriteLine("Salary:");
                        employee.Salary = Convert.ToDecimal(Console.ReadLine());

                        company.AddEmployee(employee);
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine($"Which id?");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(company.GetEmployeeById(id).FullName());
                        }
                        catch (EmployeeNotFound)
                        {
                            Console.WriteLine("Bele employee yoxdur.");
                        }
                        break;
                    case 3:
                        try
                        {
                            company.UpdateEmployee(employee);
                        }
                        catch (EmployeeNotFound)
                        {
                            Console.WriteLine("Bele employee yoxdur.");
                        }
                        break;
                    case 4:
                        try
                        {
                            company.RemoveEmployee(employee);
                        }
                        catch (EmployeeNotFound)
                        {
                            Console.WriteLine("Bele employee yoxdur.");
                        }
                        break;
                    case 5:
                        company.GetAllEmployee();
                        break;
                }

            } while (choice != 0);

        }

        static void Info()
        {
            Console.WriteLine("1 - Add employee.");
            Console.WriteLine("2 - Get employee by id.");
            Console.WriteLine("3 - Update employee.");
            Console.WriteLine("4 - Remove employee.");
            Console.WriteLine("5 - Show all employees.");
            Console.WriteLine("0 - Exit.\n");
        }
    }
}