namespace access_modifiersv2.Models;
internal class Product
{
    int _count;
    decimal _price;

    public int Count { get => _count; set { if(value >= 0) _count = value;
            else Console.WriteLine("Notebook-larin sayi 0-dan kicik ola bilmez."); } }
    public decimal Price { get => _price; set { _price = value; } }

    public Product(int count, decimal price)
    {
        this.Count = count;
        this.Price = price;
    }
}
