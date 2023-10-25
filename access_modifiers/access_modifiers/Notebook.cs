namespace access_modifiers;

internal class Notebook : Product
{
    private string _brand = string.Empty;
    private string _model;
    private byte _ram;
    private int _storage;

    public string Model
    {
        get => _model;
        set
        {
            if (_model.Length < 3 || _model.Length > 30) Console.WriteLine("Error. The name of the notebook cannot contain less than 0 and more than 30 symbols.");
            else _model = value;
        }
    }
    public byte RAM
    {
        get => _ram;
        set
        {
            if (_ram < 0 || _ram > 128) Console.WriteLine("Error, Ram cannot be higher than 128 or less than 0.");
            else _ram = value;
        }
    }
    public int Storage
    {
        get => _storage;
        set
        {
            if (_storage < 0) Console.WriteLine("Error, Storage cannot be less than 0.");
            else _storage = value;
        }
    }

    public Notebook(string model)
    {
        _model = model;
    }
}