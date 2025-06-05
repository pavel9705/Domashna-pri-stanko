using System;

class StankoFinal
{
    static void Main()
    {
        int[] counts = new int[6];
        Random rnd = new Random();

        for (int i = 0; i < 100000; i++)
        {
            int roll = rnd.Next(1, 7);
            counts[roll - 1]++;
        }

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Number {i + 1}: {counts[i]} times ({(counts[i] / 1000.0):F2}%)");
        }
    }
}
