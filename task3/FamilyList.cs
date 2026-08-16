using System;
using System.Collections.Generic;
using System.Linq;
namespace task3;

class FamilyList
{
    private Person[] familyMembers;

    public FamilyList()
    {
        familyMembers = new Person[0];
    }


    public void AddFamilyMember(Person person)
    {
        Resize();
        familyMembers[familyMembers.Length - 1] = person;
    }

    public void RemoveFamilyMember(int index)
    {
        if (index < 0 || index >= familyMembers.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must be between 0 and 4.");
        }

        for (int i = index; i < familyMembers.Length - 1; i++)
        {
            familyMembers[i] = familyMembers[i + 1];
        }

        Array.Resize(ref familyMembers, familyMembers.Length - 1);
    }

    public void Resize()
    {
        Array.Resize(ref familyMembers, familyMembers.Length + 1);
    }    

    public Person this[int index]
    {
        get
        {
            if (index < 0 || index >= familyMembers.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index must be between 0 and 4.");
            }
            return familyMembers[index];
        }
    }

    public void ShowFamilyMembers()
    {
        Console.WriteLine("Family Members:");
        foreach (var member in familyMembers)
        {
            Console.WriteLine(member.ToString());
        }
    }
    public void SortFamilyMembersByAge()
    {
        Array.Sort(familyMembers, (x, y) => x.Year.CompareTo(y.Year));
    }


    public void ShowAncestors(int index)
    {
        Person person = familyMembers[index];
        var familyTree = familyMembers.Where(m => m.Year < person.Year).OrderBy(m => m.Year).ToList();
    }

    public void ShowAncestors(Person person)
    {
        Console.WriteLine($"Ancestors of {person.Name}:");
        foreach (var member in familyMembers)
        {
            if (member.Year < person.Year)
            {
                Console.WriteLine(member.ToString());
            }
        }
    }

    public Person[] GetMembersByYear(int year)
    {
        return familyMembers.Where(m => m.Year == year).ToArray();
    }
}