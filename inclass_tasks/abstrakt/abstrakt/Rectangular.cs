namespace abstrakt;
internal class Rectangular : Fiqure
{
    private int _width;
    private int _length;

    public int Width { get => _width; set { if (value >= 0) _width = value; else Console.WriteLine("Menfi eded olmaz."); } }
    public int Length { get => _length; set { if (value >= 0) _length = value; else Console.WriteLine("Menfi eded olmaz."); } }

    public Rectangular(int width, int length)
    {
        Width = width;
        Length = length;
    }

    public override int CalcArea()
    {
        return Width * Length;
    }
}