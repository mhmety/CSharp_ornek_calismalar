using System;

class Program
{
    static void Main()
    {
        // Constants for fixed values
        const double BaseSalary = 200.0;
        const double CommissionRate = 0.09;

        // ürünlerin satış fiyatı
        double[] itemValues = { 239.99, 129.75, 99.95, 350.89 };

        // haftalık brüt satış miktarı
        Console.Write("Enter the gross sales for the week: ");
        double grossSales = double.Parse(Console.ReadLine());

        // kazanç miktarı
        double earnings = BaseSalary + (CommissionRate * grossSales);

        // kazancın yazılması
        Console.WriteLine($"Total earnings for the week: {earnings:C}");
    }
}