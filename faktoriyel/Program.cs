using System;

class Program
{
    static void Main()
    {
        Console.Write("Doğal sayı girin: ");
        int n;

        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.Write("Geçerli bir doğal sayı girin: ");
        }

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"{n}! = {factorial}");
    }
}