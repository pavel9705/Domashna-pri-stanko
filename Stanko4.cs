// hint: Намира реалните корени на полином от втора степен
using System;
using System.Linq;

class Stanko4
{
    static void Main()
    {
        Console.Write("Enter polynomial coefficients separated by ',': ");
        var coeffs = Console.ReadLine().Split(',').Select(double.Parse).ToArray();

        if (coeffs.Length != 3)
        {
            Console.WriteLine("Only quadratic (2nd degree) polynomials are supported.");
            return;
        }

        double a = coeffs[0], b = coeffs[1], c = coeffs[2];
        double d = b * b - 4 * a * c;

        if (d > 0)
        {
            Console.WriteLine($"Roots: {(-b + Math.Sqrt(d)) / (2 * a)}, {(-b - Math.Sqrt(d)) / (2 * a)}");
        }
        else if (d == 0)
        {
            Console.WriteLine($"Root: {(-b / (2 * a))}");
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }
}
