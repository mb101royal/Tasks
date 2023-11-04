using november4_task.Exceptions;
using System.Reflection.Emit;

namespace november4_task.Models
{
    internal class Company
    {
        public string Name { get; set; }
        public List<Employee> Employees;

        public Company()
        {
            Employees = new List<Employee>();
        }

        // Add employe
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        // Get employee by id
        public Employee GetEmployeeById(int id)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].Id == id)
                {
                    return Employees[i];
                }
            }
            throw new EmployeeNotFound("Bele employee yoxdur."); ;
        }
        // Update employee
        public void UpdateEmployee(Employee employee)
        {
            int id;
            if (Employees.Count != 0)
            {
                Console.WriteLine($"Id daxil edin(1 - {Employees.Count}): ");
                id = Convert.ToInt32(Console.ReadLine());

                for(int i = 0; i < Employees.Count; i++)
                {
                    if (Employees[i].Id == id)
                    {
                        Console.WriteLine("1 - modify Name");
                        Console.WriteLine("2 - modify Surname");
                        Console.WriteLine("3 - modify Age");
                        Console.WriteLine("4 - modify Gender");
                        Console.WriteLine("5 - modify Position");
                        Console.WriteLine("6 - modify Salary");

                        byte answer = Convert.ToByte(Console.ReadLine());

                        switch (answer)
                        {
                            case 1:
                                Console.WriteLine("Enter new Name");
                                employee.Name = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter new Surname");
                                employee.Surname = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter new Age");
                                employee.Age = Convert.ToByte(Console.ReadLine());
                                break;
                            case 4:
                                Console.WriteLine("Enter new Gender");
                                employee.Gender = (Genders)Convert.ToInt32(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter new Position");
                                employee.Position = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter new Salary");
                                employee.Salary = Convert.ToDecimal(Convert.ToByte(Console.ReadLine()));
                                break;
                        }
                    }
                }
            }
            else Console.WriteLine("List bosdur.");
        }
        // Remove employee
        public void RemoveEmployee(Employee employee)
        {
            int id;
            if (Employees.Count != 0)
            {
                Console.WriteLine($"Id daxil edin(1 -> {Employees.Count}): ");
                id = Convert.ToInt32(Console.ReadLine());

                if (id <= Employees.Count)
                {
                    for (int i = 0; i < Employees.Count; i++)
                    {
                        if (Employees[i].Id == id)
                        {
                            Employees.Remove(employee);
                            Console.WriteLine("Successfully removed.");
                            break;
                        } 
                    }
                }
                else throw new EmployeeNotFound("Bele employee yoxdur.");
            }
            else Console.WriteLine("List bosdur.");
        }
        // Get all employees
        public void GetAllEmployee()
        {
            if (Employees.Count != 0)
            {
                foreach (var emp in Employees)
                {
                    Console.WriteLine(emp.FullName());
                }
            }
            else { Console.WriteLine("List boshdur."); }
        }
    }
}