using after_school.Records;

namespace after_school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            (string name, string username, byte age) person = ("Tuple", "Created", 0);
            Console.WriteLine("{0} {1} {2}", person.Item1, person.Item2, person.Item3);

            var tuple2 = new Tuple<string,string,byte>("Tuple2","Created",2);
            Console.WriteLine("{0} {1} {2}", tuple2.Item1, tuple2.Item2, tuple2.Item3);

            var tuple3 = student.GetStudent();

            Console.WriteLine(tuple3);
        }
    }
}