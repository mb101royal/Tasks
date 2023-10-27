namespace access_modifiersv2.Models;
internal class Notebook : Product
{
    string _brand;
    string _model;
    int _ram;
    int _storage;

    public string Brand { get => _brand; set => _brand = value; }
    public string Model { get => _model; set { if(value.Length > 30 && value.Length < 3) _model = value;
            else Console.WriteLine("Notebook-un adi 3 simvoldan kicik, 30 simvoldan boyuk ola bilmez."); }  }
    public int RAM { get => _ram; set { if (value > 0 && value < 128) _ram = value;
            else Console.WriteLine("Ram 0-dan kicik, 128-den boyuk ola bilmez."); } }
    public int Storage { get => _storage; set { if(value > 0) _storage = value;
            else Console.WriteLine("Yaddas 0-dan kicik ola bilmez."); } }

    public Notebook(int count, decimal price, string model):base(count, price)
    {
        this.Model = model;
    }
}