namespace access_modifiers;

internal class Product
{
    private int _count;
    private int _price;

    public int Count
    {
        get => _count;
        set
        {
            if (value < 0) Console.WriteLine("Error. Count of the notebook cannot be less than 0.");
            _count = 1;
        }
    }

    public int Price
    {
        get => _price;
        set
        {
            if (value < 0) Console.WriteLine("Error. Price of the notebook cannot be less than 0.");
            _price = 1;
        }
    }


    public Product(int count, int price)
    {
        _count = count;
        _price = price;
    }

}