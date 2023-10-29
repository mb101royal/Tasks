namespace school.Models;

internal class IntList
{
    private int[] _numbers = new int[0];

    public int[] Numbers { get => _numbers; set { _numbers = value; } }

    public void Add(int number)
    {
        Array.Resize(ref _numbers, _numbers.Length + 1);
        Numbers[_numbers.Length - 1] = number;
    }

    public void Add(params int[] numbers)
    {
        Array.Resize(ref _numbers, _numbers.Length + numbers.Length);
        for (int i = 0; i < numbers.Length; i++)
        {
            Numbers[_numbers.Length - numbers.Length + i] = numbers[i];
        }
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
        foreach (int num in Numbers) Console.Write(Numbers[num] + " ");
    }
}