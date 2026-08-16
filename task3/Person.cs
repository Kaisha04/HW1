using System;

namespace task3;


class Person
{
    public string Name { get; set; }
    public int Year { get; set; }

    public Person(string name, int year)
    {
        Name = name;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Name} (Year: {Year})";
    }
}