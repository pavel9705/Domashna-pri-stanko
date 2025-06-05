// hint: Изчислява детерминантата на 3x3 матрица
using System;
using System.Linq;

class Stanko3
{
    static void Main()
    {
        Console.WriteLine("Enter 9 numbers for a 3x3 matrix, separated by ',': ");
        var input = Console.ReadLine().Split(',').Select(double.Parse).ToArray();
        double[,] matrix = new double[3, 3];
        for (int i = 0; i < 9; i++) matrix[i / 3, i % 3] = input[i];

        double det = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                   - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                   + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

        Console.WriteLine($"Determinant: {det}");
    }
}
