namespace abstrakt;
internal class Program
{
    static void Main(string[] args)
    {
        int result;
        char answer;

        do
        {
            Info();
            answer = Convert.ToChar(Console.ReadLine());

            switch (answer)
            {
                case '1':
                    Console.Write("Kvadratin sahesini hesablamaq ucun eded daxil edin: ");
                    Fiqure square = new Square(Convert.ToInt32(Console.ReadLine()));
                    square.CalcArea();
                    result = square.CalcArea();
                    Console.WriteLine($"Kvadratin sahesi: {result}");
                    break;
                case '2':
                    Console.WriteLine("Duzbucaqlinin sahesini hesablamaq ucun sira sira ededler daxil edin: ");
                    Fiqure rectangle = new Rectangular(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    result = rectangle.CalcArea();
                    Console.WriteLine($"Duzbucaqlinin sahesi: {result}");
                    break;
                case '3':
                    Console.WriteLine("Exited.");
                    break;
                default:
                    Console.WriteLine("Wrong input.");
                    break;
            }
        } while (answer != '3');
    }
    static void Info()
    {
        Console.WriteLine("1. Square");
        Console.WriteLine("2. Rectangular");
        Console.WriteLine("3. Quit");
    }
}