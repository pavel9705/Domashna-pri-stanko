using System;

class Stanko4
{
    static void Main()
    {
        Console.WriteLine("Enter 3 coefficients for ax^2 + bx + c (separated by space):");
        string[] parts = Console.ReadLine().Split();
        double a = double.Parse(parts[0]);
        double b = double.Parse(parts[1]);
        double c = double.Parse(parts[2]);

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
            Console.WriteLine("No real roots.");
        else if (discriminant == 0)
            Console.WriteLine($"One root: {-b / (2 * a)}");
        else
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Roots: {root1}, {root2}");
        }
    }
}
