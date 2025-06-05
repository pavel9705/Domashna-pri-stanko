// hint: Изчислява средно аритметично, медиана и мода
using System;
using System.Linq;

class Stanko2
{
    static void Main()
    {
        Console.Write("Enter numbers separated by ',': ");
        var numbers = Console.ReadLine().Split(',').Select(double.Parse).ToList();

        double average = numbers.Average();
        double median = numbers.OrderBy(x => x).ElementAt(numbers.Count / 2);
        double mode = numbers.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;

        Console.WriteLine($"Average: {average}, Median: {median}, Mode: {mode}");
    }
}
