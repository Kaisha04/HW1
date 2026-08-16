using System;

namespace task2;

class Program
{
    static void Main(string[] args)
    {
        MonthList monthList = new MonthList();

        
        try
        {
            Month month = monthList.GetMonth(2); // Get February
            Console.WriteLine($"Month: {month.Name}, Days: {month.CountOfDays}, Number: {month.NumberInRow}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Month[] monthsWith30Days = monthList.GetMonths(30);
            Console.WriteLine("Months with 30 days:");
            foreach (var m in monthsWith30Days)
            {
                Console.WriteLine($"Month: {m.ToString()}");
            }
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}