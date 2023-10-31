namespace custom_contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Bu bir custom contains methodudur.";

            Console.WriteLine(name.CustomContains("Bu"));
            Console.WriteLine(name.CustomContains("bu"));
            Console.WriteLine(name.CustomContains("tains"));
            Console.WriteLine(name.CustomContains("ns Methodudur"));
            Console.WriteLine(name.CustomContains("bu bir custom"));
        }
    }
}