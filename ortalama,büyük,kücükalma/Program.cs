using System;

    class Program{

        static void Main(string[] args){
            Console.WriteLine("3 adet sayi giriniz");
            Console.Write("1. sayiyi giriniz: ");
            int x= Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayiyi giriniz: ");
            int y= Convert.ToInt32(Console.ReadLine());
            Console.Write("3.sayiyi girirniz: ");
            int z= Convert.ToInt32(Console.ReadLine());

            int[] xyz = new int[3]{x,y,z};
            int ort= ((x+y+z)/3);

            Console.WriteLine("En küçük sayi: " + xyz.Min()); //.Min komutu ile girilen sayılardan en küçüğünü istedik
            Console.WriteLine("En büyük sayi: " + xyz.Max()); //.Max komutu ile girilen sayılardan en büyüğünü istedik
            Console.WriteLine("girdiğiniz sayilarin ortalamasi: " + ort);

        }
    }
