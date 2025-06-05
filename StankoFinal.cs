// hint: Симулира 100000 хвърляния на зар и показва честотите
using System;

class StankoFinal
{
    static void Main()
    {
        var rnd = new Random();
        int[] freq = new int[6];

        for (int i = 0; i < 100000; i++)
        {
            freq[rnd.Next(0, 6)]++;
        }

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Number {i + 1}: {(freq[i] / 100000.0) * 100:F2}%");
        }
    }
}
