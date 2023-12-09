using System;

class Program
{
    static void Main()
    {
        const double growthRate = 0.011; 
        double currentPopulation = 7.9e9; 

        Console.WriteLine("Yıl\tBeklenen Nüfus\tArtış\t\tArtış Miktarı");

        for (int year = 1; year <= 75; year++)
        {
            double expectedPopulation = currentPopulation * (1 + growthRate);
            double populationIncrease = expectedPopulation - currentPopulation;

            Console.WriteLine($"{year}\t{expectedPopulation:F0}\t\t{populationIncrease:F0}\t\t{growthRate * 100:F2}%");

            currentPopulation = expectedPopulation;
        }

        Console.WriteLine("\nNüfusun iki katına çıkacağı yıl: " + FindDoublingYear(currentPopulation, growthRate));
    }

    static int FindDoublingYear(double currentPopulation, double growthRate)
    {
        int year = 0;

        while (currentPopulation < currentPopulation * 2)
        {
            currentPopulation = currentPopulation * (1 + growthRate);
            year++;
        }

        return year;
    }
}