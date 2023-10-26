namespace after_school.Records;

internal record Student
{
    public string Name { get; init; } = "Celil";
    public string Surname { get; init; } = "Celilov";
    public byte Age { get; init; } = 10;

    public Student()
    {
        Console.WriteLine("Normal: "+ Name + " " + Surname + " " + Age);
        Console.WriteLine($"With Formatted string: {Name} {Surname} {Age}\n");
    }

    public Tuple<string, string, byte> GetStudent()
    {
        return Tuple.Create(Name, Surname, (byte)Age);
    }
}
