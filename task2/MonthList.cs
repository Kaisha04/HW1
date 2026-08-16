using System;

namespace task2;

class MonthList
{
    private Month[] months;

    public MonthList()
    {
        months = new Month[12];
        months[0] = new Month("January", 31, 1);
        months[1] = new Month("February", 28, 2);
        months[2] = new Month("March", 31, 3);
        months[3] = new Month("April", 30, 4);
        months[4] = new Month("May", 31, 5);
        months[5] = new Month("June", 30, 6);
        months[6] = new Month("July", 31, 7);
        months[7] = new Month("August", 31, 8);
        months[8] = new Month("September", 30, 9);
        months[9] = new Month("October", 31, 10);
        months[10] = new Month("November", 30, 11);
        months[11] = new Month("December", 31, 12);
    }

    public Month GetMonth(int index)
    {
        index = index - 1; // Adjust for 0-based index
        if (index < 0 || index >= months.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must be between 1 and 12.");
        }
        return months[index];
    }

    public Month[] GetMonths(int countOfDays)
    {
        Month[] result = new Month[12]; // Assuming maximum 12 months with the same number of days
        int count = 0;

        for (int i = 0; i < months.Length; i++)
        {
            if (months[i].CountOfDays == countOfDays)
            {
                result[count] = months[i];
                count++;
            }
        }

        if (count == 0)
        {
            throw new ArgumentOutOfRangeException(nameof(countOfDays), "No month found with the specified number of days.");
        }

        Array.Resize(ref result, count);
        return result;
    }
}