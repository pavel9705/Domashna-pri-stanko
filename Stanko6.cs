// hint: Изчислява дължините на 3D вектори
using System;
using System.Linq;

class Stanko6
{
    static void Main()
    {
        Console.Write("Enter vectors like x y z | x y z ... : ");
        var input = Console.ReadLine().Split('|');

        foreach (var vectorStr in input)
        {
            var coords = vectorStr.Trim().Split(' ').Select(double.Parse).ToArray();
            double length = Math.Sqrt(coords[0] * coords[0] + coords[1] * coords[1] + coords[2] * coords[2]);
            Console.WriteLine($"Length: {length}");
        }
    }
}
