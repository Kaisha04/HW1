using System;

namespace task6;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var squaresOfOddNumbers = Program.SquaresOfOddNumbers(numbers);
        foreach (var square in squaresOfOddNumbers)
        {
            Console.WriteLine(square);
        }
    }
    
    public static List<int> SquaresOfOddNumbers (int[] array)
    {
        var result = array.Where(x => x % 2 != 0).Select(x => x * x).ToList();
        return result;
    }
}