using System;
using System.Linq;

class Stanko5
{
    static void Main()
    {
        Console.WriteLine("Enter number of 3D vectors:");
        int n = int.Parse(Console.ReadLine());

        double minLength = double.MaxValue;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter vector {i + 1} (x y z):");
            double[] v = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double length = Math.Sqrt(v[0] * v[0] + v[1] * v[1] + v[2] * v[2]);

            if (length < minLength)
                minLength = length;
        }

        Console.WriteLine($"Shortest vector length: {minLength:F2}");
    }
}
