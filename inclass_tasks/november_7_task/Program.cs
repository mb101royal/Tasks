namespace november_7_task
{
    delegate int CustomDelegate(int num1, int num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            CustomDelegate multiDel = new CustomDelegate(program.Multiply);
            CustomDelegate sumDel = new CustomDelegate(program.Sum);
            CustomDelegate substrDel = new CustomDelegate(program.Substract);

            Console.WriteLine($"Multiplication: {multiDel(2, 3)}");
            Console.WriteLine($"Sum: {sumDel(2, 3)}");
            Console.WriteLine($"Substraction: {substrDel(2, 3)}");
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}