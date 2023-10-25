namespace Company_and_Employee.Models;

internal class Company
{
    private string _name;
    private Employee[] _employees;

    public string Name
    {
        get => _name;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                value = value.Trim();
                _name = value;
            }
        }
    }

    public Employee[] Employees;

    public Company(string name)
    {
        Name = name;
        Employees = new Employee[0];
    }

    public void AddUser(Employee user)
    {

        Array.Resize(ref Employees, Employees.Length + 1);
        Employees[Employees.Length - 1] = user;
        Console.WriteLine("User added.");
    }
    public void RemoveUser(string username)
    {
        for (int i = 0; i < Employees.Length; i++)
        {
            if (Employees[i].Username == username)
            {
                Employee temp = Employees[Employees.Length - 1];
                Employees[Employees.Length - 1] = Employees[i];
                Employees[i] = temp;
                Employees[Employees.Length - 1] = null;
                Array.Resize(ref Employees, Employees.Length - 1);
                Console.WriteLine("User removed.");
                break;
            }
            else continue;
        }
    }
    public Employee GetUser(string username)
    {
        foreach (Employee emp in Employees)
        {
            if (emp.Username == username) return emp;
        }
        Console.WriteLine("Bele user yoxdur.");
        return null;
    }
    /*public string UpdateUser(string username)
    {

    }*/
    public void GetAllUsers()
    {
        if (Employees.Length > 0)
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine($"User: {emp}");
            }
        }
        else Console.WriteLine("Your employee list is empty.");
    }
}