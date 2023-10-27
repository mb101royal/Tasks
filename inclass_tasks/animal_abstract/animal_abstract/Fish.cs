namespace animal_abstract;

internal abstract class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine("Swam.");
    }

    public override void Eat()
    {
        Console.WriteLine("Fish is eating");
    }
}