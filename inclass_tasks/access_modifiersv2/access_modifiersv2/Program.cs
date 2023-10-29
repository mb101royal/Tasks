using access_modifiersv2.Models;

namespace access_modifiersv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notbuklarin sayini qeyd edin: ");

            int count = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.Write("Brand daxil edin: ");
                string brand = Console.ReadLine();
                Console.Write("Qiymet daxil edin: ");
                decimal price = Convert.ToInt32(Console.ReadLine());

                Notebook notebook = new Notebook(count, 20, brand);


            }
        }
    }
}