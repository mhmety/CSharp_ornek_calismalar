// See https://aka.ms/new-console-template for more information
using System;   


namespace BmiCalculator{
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome To BMI Calculator");
        Console.WriteLine("What is your weight to kg?");
        float weight= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is your height to cm?");
        float cm = Convert.ToInt32(Console.ReadLine());
        float m = cm / 100;

        float bmi = weight / (m * m);

        Console.WriteLine("thats your Bmi:" + bmi);

        if(bmi <= 18.4){
            Console.WriteLine("your body index underweight");
        }

        else if(18.5 < bmi && bmi < 25.0){
            Console.WriteLine("your body index normal");
        }

        else if(25.0 < bmi && bmi < 39.9){
            Console.WriteLine("your body index overweight");
        }

        else{
            Console.WriteLine("OBESE!!");
        }
    }
}
}