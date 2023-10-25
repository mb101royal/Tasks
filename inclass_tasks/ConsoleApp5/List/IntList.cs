namespace List;

internal class IntList
{
    private int[] _numbers;

    public int[] Numbers { get => _numbers; set { } }


    public void Add(int number)
    {
        Array.Resize(ref _numbers, _numbers.Length + 1);
        Numbers[_numbers.Length - 1] = number;
    }

    public void Add(params int[] numbers)
    {
        Array.Resize(ref _numbers, _numbers.Length + numbers.Length);
        Numbers[_numbers.Length - 1] = numbers;
    }

    public int Get(int index)
    {
        for (int i = 0; i < Numbers.Length; i++)
        {
            if (Numbers[i] == index) break;
            index++;
        }
        return index;
    }
    public int[] GetAll()
    {
        return Numbers;
    }
    public void Print()
    {
        foreach (int i in Numbers) Console.Write(Numbers[i] + " ");
    }
}
