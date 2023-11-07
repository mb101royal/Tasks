using november4_task.Exceptions;

namespace november4_task.Models
{
    delegate void ShowAll();
    internal static class EmployeeService
    {
        // Add employe
        public static void AddEmployee(Employee employee)
        {
            EmployeeDatabase.Employees.Add(employee);
        }
        // Get employee by id
        public static Employee GetEmployeeById(int id)
        {
            /*if (id > 0 && id <= Employees.Count) return Employees.Find(emp => emp.Id == id);
            if (id > 0 && id <= Employees.Count) return Employees.SingleOrDefault(emp => emp.Id == id);*/
            if (id > 0 && id <= EmployeeDatabase.Employees.Count) return EmployeeDatabase.Employees.FirstOrDefault(emp => emp.Id == id);

            throw new EmployeeNotFound("Bele id-e sahib employee yoxdur.");
        }
        // Update employee
        public static void UpdateEmployee(this Employee employee)
        {
            int id;
            if (EmployeeDatabase.Employees.Count != 0)
            {
                Console.WriteLine($"Id daxil edin(1 - {EmployeeDatabase.Employees.Count}): ");
                id = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < EmployeeDatabase.Employees.Count; i++)
                {
                    if (EmployeeDatabase.Employees[i].Id == id)
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
                            retry:
                                Console.WriteLine("Enter new Gender(1 - male, 2 - female, 3 - other).");
                                int newGen = Convert.ToInt32(Console.ReadLine());

                                if (newGen < 4 && newGen > 0)
                                    employee.Gender = (Genders)newGen;
                                else
                                {
                                    Console.WriteLine("Gender is incorrect.");
                                    goto retry;
                                }
                                break;
                            case 5:
                            retry2:
                                Console.WriteLine("Enter new Position(1 - Front, 2 - Back, 3 - Full, 4 - DevOps).");
                                int newPos = Convert.ToInt32(Console.ReadLine());

                                if (newPos <= 4 && newPos > 0)
                                    employee.Position = (Positions)newPos;
                                else
                                {
                                    Console.WriteLine("Position is incorrect.");
                                    goto retry2;
                                }
                                break;
                            case 6:
                                Console.WriteLine("Enter new Salary");
                                employee.Salary = Convert.ToDecimal(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            else Console.WriteLine("List bosdur.");
        }
        // Remove employee
        public static void RemoveEmployee(this Employee employee)
        {
            int id;
            if (EmployeeDatabase.Employees.Count != 0)
            {
                Console.WriteLine($"Id daxil edin: ");
                foreach (var emp in EmployeeDatabase.Employees)
                    Console.Write(emp.Id + " ");
                Console.WriteLine();
                id = Convert.ToInt32(Console.ReadLine());

                if (id <= employee.Id && id > 0)
                {
                    EmployeeDatabase.Employees.Remove(EmployeeDatabase.Employees.Find(emp => emp.Id == id));
                    Console.WriteLine("Removed successully.");
                    /*Employees.Remove(Employees.SingleOrDefault(emp => emp.Id == id));
                    Console.WriteLine("Removed successully.");
                    Employees.Remove(Employees.FirstOrDefault(emp => emp.Id == id));
                    Console.WriteLine("Removed successully.");*/

                }
                else throw new EmployeeNotFound("Bele employee yoxdur.");
            }
            else Console.WriteLine("List bosdur.");
        }
        // Get all employees
        public static void GetAllEmployee()
        {
            ShowAll showAll = new ShowAll(ForDelegate);
            showAll();
        }
        public static void ForDelegate()
        {
            if (EmployeeDatabase.Employees.Count != 0)
            {
                foreach (var emp in EmployeeDatabase.Employees)
                    Console.WriteLine(emp.FullName());
            }
            else Console.WriteLine("List boshdur.");
        }
    }
}
