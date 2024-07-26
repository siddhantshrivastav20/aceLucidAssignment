using System;

class PrintTriangle
{
    static void Main()
    {
        Console.Write("Enter the number of rows for the triangle: ");
        int rows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            // Print spaces
            for (int j = rows; j > i; j--)
            {
                Console.Write(" ");
            }
            // Print stars
            for (int k = 1; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

