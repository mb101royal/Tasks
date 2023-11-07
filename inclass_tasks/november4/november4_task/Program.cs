using november4_task.Exceptions;
using november4_task.Models;

namespace november4_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Company company = new()
            {
                Name = "corp"
            };

            EmployeeDatabase.Companies.Add(company);*/

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
                        nameretry:
                        employee.Name = Console.ReadLine();

                        if (employee.Name.Length < 3 || employee.Name.Length > 30)
                        {
                            Console.WriteLine("The name is incorrect.");
                            goto nameretry;
                        }

                        Console.WriteLine("Surname:");
                        employee.Surname = Console.ReadLine();

                        Console.WriteLine("Age:");
                        employee.Age = Convert.ToByte(Console.ReadLine());

                    retry:
                        Console.WriteLine("Gender(1 - male, 2 - female, 3 - other):");
                        int gender = Convert.ToInt32(Console.ReadLine()) ;

                        if (gender < 4 && gender > 0)
                            employee.Gender = (Genders)gender;
                        else
                        {
                            Console.WriteLine("Gender is incorrect.");
                            goto retry;
                        }

                    retry2:
                        Console.WriteLine("Position(1 - Front, 2 - Back, 3 - Full, 4 - DevOps):");
                        int position = Convert.ToInt32(Console.ReadLine());

                        if (position <= 4 && position > 0)
                            employee.Position = (Positions)position;
                        else
                        {
                            Console.WriteLine("Position is incorrect.");
                            goto retry2;
                        }

                        Console.WriteLine("Salary:");
                        employee.Salary = Convert.ToDecimal(Console.ReadLine());
                           
                        EmployeeService.AddEmployee(employee);
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine($"Which id?");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(EmployeeService.GetEmployeeById(id).FullName());
                        }
                        catch (EmployeeNotFound)
                        {
                            Console.WriteLine("Bele employee yoxdur.");
                        }
                        break;
                    case 3:
                        try
                        {
                            EmployeeService.UpdateEmployee(employee);
                        }
                        catch (EmployeeNotFound)
                        {
                            Console.WriteLine("Bele employee yoxdur.");
                        }
                        break;
                    case 4:
                        try
                        {
                            EmployeeService.RemoveEmployee(employee);
                        }
                        catch (EmployeeNotFound)
                        {
                            Console.WriteLine("Bele employee yoxdur.");
                        }
                        break;
                    case 5:
                        EmployeeService.GetAllEmployee();
                        break;
                }

            } while (choice != 0);

        }

        static void Info()
        {
            Console.WriteLine("1 - Add employee.");
            Console.WriteLine("2 - Get employee details by id.");
            Console.WriteLine("3 - Update employee details.");
            Console.WriteLine("4 - Remove employee.");
            Console.WriteLine("5 - Show all employees.");
            Console.WriteLine("0 - Exit.\n");
        }
    }
}