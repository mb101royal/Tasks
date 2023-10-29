namespace animal_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fish dolphin = new Dolphin();
            Bird owl = new Owl();

            dolphin.Swim();
            dolphin.Eat();

            owl.Fly();
            owl.Eat();
        }
    }
}