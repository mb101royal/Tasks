using school.Models;

namespace school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group();
            Group group2 = new Group();
            Group group3 = new Group();

            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            Lesson lesson = new Lesson();
            Lesson lesson2 = new Lesson();
            Lesson lesson3 = new Lesson();

            IntList list = new IntList();

            list.Add(2);
            list.Add(new int[] { 1, 2, 3, 4 });
            list.Get(2);
            list.GetAll();
            list.Print();


        }
    }
}