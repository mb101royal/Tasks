namespace Company_and_Employee.Models;

internal class Company
{
    private string _name;
    private Employee[] _employees = new Employee[100];

    public string Name
    {
        get => _name;
        set
        {

        }
    }

    public Employee[] Employees
    {
        get => _employees;
        set
        {

        }
    }

    public Company(string name)
    {
        name = Name;
    }
    
   /* public void AddUser(Employee user)
    {

    }
    public void RemoveUser(string username)
    {
       
    }
    public string GetUser(string username)
    {

    }
    public string UpdateUser(string username)
    {

    }*/
}
