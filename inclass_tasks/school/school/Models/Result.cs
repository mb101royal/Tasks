namespace school.Models;

internal class Result
{
    private Lesson _lesson;
    private float _grade;

    public Lesson Lesson { get => _lesson; set { _lesson = value; } }
    public float Grade { get => _grade; set { _grade = value; } }
}