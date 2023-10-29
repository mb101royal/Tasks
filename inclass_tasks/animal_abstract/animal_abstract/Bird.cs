namespace animal_abstract;

internal class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine("Flew.");
    }
    public override void Eat()
    {
        Console.WriteLine("Bird is also eating.");
    }
}