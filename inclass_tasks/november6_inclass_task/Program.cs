using november6_inclass_task.Models;

namespace november6_inclass_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            List<Person> people = new List<Person>();

            people.Add(new Person { Name = "Salam1", Surname = "Salamov", Age = 20 });
            people.Add(new Person { Name = "Salam2", Surname = "Salamova", Age = 20 });
            people.Add(new Person { Name = "Salam3", Surname = "Salamo", Age = 20 });
            people.Add(new Person { Name = "herf", Surname = "Salamovav", Age = 17 });

            // 4 herfli adlar:
            Console.WriteLine("4 herfden ibaret olanlar: ");
            var result1 = people.FindAll(person => person.Name.Length == 4);
            foreach(var p in result1)
            {
                Console.Write(p + " ");
            }

            // soyadi ov, ova ile bitenler:
            Console.WriteLine("\nSoyadi ov, ova ile bitenler: ");
            var result2 = people.FindAll(person => person.Surname.EndsWith("ov") || person.Surname.EndsWith("ova"));
            foreach (var p in result2)
            {
                Console.Write(p + ", ");
            }

            // Yashi 18+ olanlar:
            Console.WriteLine("\nYashi 18+ olanlar: ");
            var result3 = people.FindAll(person => person.Age >= 18);
            foreach (var p in result3)
            {
                Console.Write(p + ", ");
            }

            // Ancaq yashlar:
            Console.WriteLine("\nAncaq yashlar: ");
            var result4 = people.Select(person => person.Age);
            foreach (var p in result4)
            {
                Console.Write(p + " ");
            }
        }
    }
}