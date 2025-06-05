using System;
using System.Linq;

class Stanko3
{
    static void Main()
    {
        Console.WriteLine("Enter 9 numbers for 3x3 matrix separated by space:");
        double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[,] m = new double[3, 3];

        for (int i = 0; i < 9; i++)
            m[i / 3, i % 3] = input[i];

        Console.WriteLine("Matrix as list:");
        Console.WriteLine(string.Join("'", input));

        double det =
            m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) -
            m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
            m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);

        Console.WriteLine("Determinant: " + det);
    }
}
