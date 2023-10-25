namespace Company_and_Employee.Models;

public class Employee
{
    private string _name;
    private string _surname;
    private byte _age;
    private string _username;

    public string Name
    {
        get => _name;
        set
        {
            
            if (!string.IsNullOrWhiteSpace(value))
            {
                value = value.Trim();
                _name = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
    }
    public string Surname
    {
        get => _surname;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                value = value.Trim();
               _surname = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
    }

    public byte Age
    {
        get => _age;
        set
        {
            if (value <= 0) Console.WriteLine("Xeta");
            else _age = value;
        }
    }

    public string Username
    {
        get => _username;
        set { _username = value; }
    }

    public Employee(string name, string surname)
    {
        Name = name;
        Surname = surname;

        Username = $"{_name}_{_surname}";
    }
}