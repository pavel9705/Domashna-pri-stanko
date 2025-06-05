using System;
using System.Numerics;

class Stanko7
{
    static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter two integers (n and k):");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger permutations = Factorial(n);
        BigInteger combinations = Factorial(n) / (Factorial(k) * Factorial(n - k));
        BigInteger variations = Factorial(n) / Factorial(n - k);

        Console.WriteLine($"Permutations: {permutations}");
        Console.WriteLine($"Combinations: {combinations}");
        Console.WriteLine($"Variations: {variations}");
    }
}
