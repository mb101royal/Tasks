namespace Company_and_Employee.Models;

public class Employee
{
    private string _name;
    private byte _age;
    private string _username;
    private string _surname;

    public string Name
    {
        get => _name;
        set
        {
            value = value.Trim();
            if (!string.IsNullOrWhiteSpace(value)) _name = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
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
        set { }
    }

    public string Surname
    {
        get => _surname;
        set
        {
            value = value.Trim();
            if (!string.IsNullOrWhiteSpace(value)) _surname = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
        }
    }

    public Employee(byte age, string name, string surname)
    {
        Age = age;
        Name = name;
        Surname = surname;

        Username = $"{name}_{surname}";
    }

    public void GetInfo()
    {
        string result = $"{Name} {Surname} {Age}";

        Console.WriteLine(result);
    }
}