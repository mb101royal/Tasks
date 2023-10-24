namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntList list = new IntList();

            list.Add(2);
            list.Add(new int[] { 1, 2, 3, 4 });
            list.Get(2);
            list.GetAll();
            list.Print();
        }
    }
}