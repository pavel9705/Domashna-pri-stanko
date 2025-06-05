using System;
using System.Linq;
using System.Collections.Generic;

class Stanko2
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by spaces:");
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        double mean = numbers.Average();
        double median = numbers.OrderBy(n => n).ElementAt(numbers.Count / 2);
        double mode = numbers.GroupBy(n => n).OrderByDescending(g => g.Count()).First().Key;

        Console.WriteLine($"Mean: {mean:F2}, Mode: {mode}, Median: {median}");
    }
}
