using System;

namespace rakamdankelime{

    class Program{

        static void Main(string[]args){

            basasar: //konum etiketi
            Console.WriteLine("bir rakam giriniz");
            int rakam = Convert.ToInt32(Console.ReadLine());

            switch(rakam){
                case 0:
                    Console.WriteLine("yazdığınız rakam 'sıfır'");
                    break;
                case 1:
                    Console.WriteLine("yazdığınız rakam 'bir'");
                    break;
                case 2:
                    Console.WriteLine("yazdığınız rakam 'iki'");
                    break;
                case 3:
                    Console.WriteLine("yazdığınız rakam 'üç'");
                    break;
                case 4:
                    Console.WriteLine("yazdığınız rakam 'dört'");
                    break;
                case 5:
                    Console.WriteLine("yazdığınız rakam 'beş'");
                    break;
                case 6:
                    Console.WriteLine("yazdığınız rakam 'altı'");
                    break;
                case 7:
                    Console.WriteLine("yazdığınız rakam 'yedi'");
                    break;
                case 8:
                    Console.WriteLine("yazdığınız rakam 'sekiz'");
                    break;
                case 9:
                    Console.WriteLine("yazdığınız rakam 'dokuz'");
                    break;
                default:
                    Console.WriteLine("yanlış bir sayı girdiniz lütfen rakam giriniz:");
                    goto basasar; //hatalı girilme durumunda programın tekrar çalışması için
                    break; 
                
            }       
        }
    }
}
