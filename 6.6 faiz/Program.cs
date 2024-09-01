using System;

class interest{

static void Main()
{
    Console.WriteLine("miktari giriikiininiz: ");
    decimal para = Convert.ToInt32(Console.ReadLine());
    decimal principal = para; // para  
    double rate = 0.025; // faiz oranı

    Console.WriteLine("Year Amount on deposit");


    for (int year = 1; year <= 12; ++year)
    {
 
        decimal amount = principal *
            ((decimal) Math.Pow(1.0 + rate, year));



        Console.WriteLine($"{year,4}{amount,20:C}");
    }
}
}