namespace school.Models;

internal class Group
{
    private int _studentCount;
    private string _faculty;

    public int StudentCount { get => _studentCount; set { _studentCount = value; } }
    public string Faculty { get => _faculty; set { _faculty = value; } }

    /*public Group(int count, string name)
    {
        StudentCount = count;
        Faculty = name;
    }*/
}