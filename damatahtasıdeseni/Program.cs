using System;

class Program
{
    static void Main()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if ((row + col) % 2 == 0)
                {
                    Console.Write("* ");
                }
                else
                
                    Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
}
