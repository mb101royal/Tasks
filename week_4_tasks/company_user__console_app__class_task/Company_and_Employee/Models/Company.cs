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
            if (emp.Username == username)
            {
                Console.WriteLine(emp.ToString());
                return emp;
			}
            else break;
		}
        Console.WriteLine("There's no user like this.");
        return null;
    }

	public string UpdateUser(string username)
	{
		Console.WriteLine("What would you like to change:");
		Console.WriteLine("1. Update Name");
		Console.WriteLine("2. Update Surname");
		Console.WriteLine("3. Update Age");

		char choice = Convert.ToChar(Console.ReadLine());
		Employee updatedEmployee = null;

		foreach (Employee emp in Employees)
		{
			if (emp.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
			{
				updatedEmployee = emp;

				if (choice == '1')
				{
					Console.WriteLine("Enter new Name:");
					string newName = Console.ReadLine();
					emp.Name = newName;

					emp.Username =
						$"{emp.Name.Substring(0, 1).ToUpper() + emp.Name.Substring(1).ToLower()}_" +
						$"{emp.Surname.Substring(0, 1).ToUpper() + emp.Surname.Substring(1).ToLower()}";
				}
				else if (choice == '2')
				{
					Console.WriteLine("Enter new Surname:");
					string newSurname = Console.ReadLine();
					emp.Surname = newSurname;

					emp.Username = 
						$"{emp.Name.Substring(0, 1).ToUpper() + emp.Name.Substring(1).ToLower()}_" +
						$"{emp.Surname.Substring(0, 1).ToUpper() + emp.Surname.Substring(1).ToLower()}";
				}
				else if (choice == '3')
				{
					Console.WriteLine("Enter new Age:");
					if (byte.TryParse(Console.ReadLine(), out byte newAge)) emp.Age = newAge;
					else Console.WriteLine("Invalid input for Age.");
				}
				else Console.WriteLine("Invalid choice.");

				Console.WriteLine($"Updated details for {username}: {emp.Name}, {emp.Surname}, {emp.Username}");
				break;
			}
		}
		if (updatedEmployee == null) return "User not found.";

		return "User updated successfully.";
	}

	public void GetAllUsers()
    {
        if (Employees != null && Employees.Length > 0) foreach (Employee emp in Employees) Console.WriteLine(emp.ToString());
        else Console.WriteLine("Your employee list is empty.");
    }

	public void CreateNewCompany()
    {
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		Console.WriteLine("You want more than you can get 🥲😞");
    }
}