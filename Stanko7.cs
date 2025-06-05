// hint: Извършва сечение, обединение, разлика и допълнение между две множества
using System;
using System.Linq;
using System.Collections.Generic;

class Stanko7
{
    static void Main()
    {
        Console.Write("Enter set A: ");
        var a = Console.ReadLine().Split(',').Select(int.Parse).ToHashSet();

        Console.Write("Enter set B: ");
        var b = Console.ReadLine().Split(',').Select(int.Parse).ToHashSet();

        Console.WriteLine($"Intersection: {string.Join(",", a.Intersect(b))}");
        Console.WriteLine($"Union: {string.Join(",", a.Union(b))}");
        Console.WriteLine($"Difference (A - B): {string.Join(",", a.Except(b))}");
        Console.WriteLine($"Complement (B - A): {string.Join(",", b.Except(a))}");
    }
}
