namespace abstrakt
{
    internal class Square : Fiqure
    {
        private int _side;
        public int Side { get => _side; set { if (value >= 0) _side = value; else Console.WriteLine("Menfi eded olmaz."); } }

        public Square(int side)
        {
            Side = side;
        }
        public override int CalcArea()
        {
            return Side*Side;
        }
    }
}