using System;

namespace xyzcarp{

    class Program{

        static void Main(string[] args){

            Console.WriteLine("**girilen 3 sayinin çarpimi**");
            Console.WriteLine("1. sayiyi giriniz");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayiyi giriniz");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. sayiyi giriniz");
            int z = Convert.ToInt32(Console.ReadLine());

            int urun = (x*y*z);

            Console.WriteLine("sonuç:"+ urun);
        }
    }
}