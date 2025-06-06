using System;

class Stanko1
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        Console.WriteLine("Choose: 1 - Decimal to another base, 2 - Another base to decimal");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter target base (2 to 16): ");
            int toBase = int.Parse(Console.ReadLine());
            int number = int.Parse(input);
            Console.WriteLine($"Result: {Convert.ToString(number, toBase)}");
        }
        else
        {
            Console.Write("Enter source base: ");
            int fromBase = int.Parse(Console.ReadLine());
            int number = Convert.ToInt32(input, fromBase);
            Console.WriteLine($"Decimal: {number}");
        }
    }
}
