using System;

namespace alışveris{

    class Program{

        static void Main(string[] args){

            Console.WriteLine("1.ürünü fiyatini giriniz: ");
            int ilkUrun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.ürünü fiyatini giriniz: ");
            int ikinciUrun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.ürünü fiyatini giriniz: ");
            int ucuncuUrun = Convert.ToInt32(Console.ReadLine());

            int ilkind = ilkUrun - (ilkUrun/10);
            int ikinciind = ikinciUrun - (ikinciUrun/10);
            int ucuncuind = ucuncuUrun - (ucuncuUrun/10);

            Console.WriteLine("ürünlere %10 indirim uygulaniyor...");
            Console.WriteLine("indirim uygulanmiş fiyatlar");
            Console.WriteLine("1.ürün: "+ ilkind);
            Console.WriteLine("2.ürün: "+ ikinciind);
            Console.WriteLine("3.ürün: "+ ucuncuind);





        }
    }
}