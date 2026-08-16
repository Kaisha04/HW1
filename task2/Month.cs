using System;

namespace task2;

public class Month
{
    public string Name  { get; set; }
    public int CountOfDays { get; set; }
    public int NumberInRow { get; set; }

    public Month(string name, int countOfDays, int numberInRow)
    {
        Name = name;
        CountOfDays = countOfDays;
        NumberInRow = numberInRow;
    }

    public override string ToString()
    {
        return $"{Name} ({CountOfDays} days, Number: {NumberInRow})";
    }
} 