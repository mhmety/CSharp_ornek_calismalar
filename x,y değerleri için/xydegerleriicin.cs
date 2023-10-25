using System;

namespace xybelli{

    class Program{

        static void Main(string[] args){

            int x= 2;
            int y= 3;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"Value of {x} + {x} is {x + x}");
            Console.WriteLine("x =");
            Console.WriteLine($"{x + y} = {y + x}");

        }
    }
}