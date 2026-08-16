using System;

namespace task3;


class Program
{
    static void Main()
    {
        FamilyList familyList = new FamilyList();
        //add family members
        familyList.AddFamilyMember(new Person("Alice", 1990));
        familyList.AddFamilyMember(new Person("Bob", 1985));
        familyList.AddFamilyMember(new Person("Charlie", 1980));
        familyList.AddFamilyMember(new Person("David", 1975));
        familyList.AddFamilyMember(new Person("Eve", 1970));
        familyList.AddFamilyMember(new Person("Nekit", 1985));
        familyList.ShowFamilyMembers();


        System.Console.WriteLine("________________________");
        //remove a family member
        familyList.RemoveFamilyMember(2); // Remove Charlie
        familyList.ShowFamilyMembers();


        System.Console.WriteLine("________________________");
        var member = familyList[1]; // Get Bob

        System.Console.WriteLine($"Member: {member.Name}, Year: {member.Year}");

        System.Console.WriteLine("________________________");
        familyList.ShowAncestors(member);

        System.Console.WriteLine("________________________");
        // Sort family members by age
        familyList.SortFamilyMembersByAge();
        familyList.ShowFamilyMembers();

        System.Console.WriteLine("________________________");
        // Get members by year
        var membersByYear = familyList.GetMembersByYear(1985);
        Console.WriteLine("Members born in 1985:");
        foreach (var m in membersByYear)
        {
            Console.WriteLine($"Member: {m.Name}, Year: {m.Year}");
        }
    }
}