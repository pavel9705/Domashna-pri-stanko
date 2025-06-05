using System;
using System.Linq;
using System.Collections.Generic;

class Stanko6
{
    static void Main()
    {
        Console.WriteLine("Enter first set (numbers separated by space):");
        var set1 = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

        Console.WriteLine("Enter second set:");
        var set2 = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

        var union = set1.Union(set2);
        var intersection = set1.Intersect(set2);
        var difference = set1.Except(set2);
        var symmetricDiff = union.Except(intersection);

        Console.WriteLine("Union: " + string.Join(" ", union));
        Console.WriteLine("Intersection: " + string.Join(" ", intersection));
        Console.WriteLine("Difference (Set1 - Set2): " + string.Join(" ", difference));
        Console.WriteLine("Symmetric Difference: " + string.Join(" ", symmetricDiff));
    }
}
