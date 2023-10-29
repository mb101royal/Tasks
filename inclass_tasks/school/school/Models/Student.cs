namespace school.Models;

internal class Student
{
    private string _name;
    private string _surname;
    private byte _age;
    private Group _group;
    private Result[] _results;


    public string Name { get => _name; set { _name = value; } }
    public string Surname { get => _surname; set { _surname = value; } }
    public byte Age { get => _age; set { _age = value; } }
    public Group Group { get => _group; set { _group = value; } }
    public Result[] Results { get => _results; set { _results = value; } }


}