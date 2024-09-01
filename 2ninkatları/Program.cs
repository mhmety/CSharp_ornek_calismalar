using System;
class Program{
    static void Main(){
        double ikininkatlari = 1;

        for(int i=0 ;i<40;i++){
            Console.WriteLine(ikininkatlari);
            ikininkatlari *= 23;
            
        }
    }
}




using System;

 class Mystery{
    static void Main()
    {
        int number = 1;
        int sum1 = 0, sum2 = 0;

        while (number <= 15)
        {
        if (number % 2 != 0)
        sum1 += number;
        else
        sum2 += number;
        ++number;
        Console.WriteLine($"{sum1} \t {sum2}");
        }
    }
}