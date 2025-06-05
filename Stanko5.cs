// hint: Намира дължината на най-късия низ в списък
using System;
using System.Linq;

class Stanko5
{
    static void Main()
    {
        Console.Write("Enter strings separated by ',': ");
        var strings = Console.ReadLine().Split(',');
        int minLen = strings.Min(s => s.Length);

        Console.WriteLine($"Shortest length: {minLen}");
    }
}
