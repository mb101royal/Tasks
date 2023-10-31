namespace products;
internal class Book : Product
{
    public string AuthorName { get; set; }
    public int PageCount { get; set; }

    public override void Sell()
    {
        --Count;
        TotalIncome += Price;
        Console.WriteLine("Kitab satildi.");
    }

    public override string ShowInfo()
    {
        return $"{Id}. Ad: {Name}, Avtor: {AuthorName}, Qiymet: {Price}azn, Sehife sayi: {PageCount}";
    }
}
