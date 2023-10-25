using System;

namespace haftaicivesonu{

    class Program{

        static void Main(string[] args){
            basasar:
            Console.WriteLine("haftanin kaçinci günü olduğunu giriniz: ");
            int gün = Convert.ToInt32(Console.ReadLine());

            switch(gün){
                case 1:
                    Console.WriteLine("haftanin 1. günü pazartesi");
                    Console.WriteLine("haftaiçi");
                    break;
                case 2:
                    Console.WriteLine("haftanin 2. günü sali");
                    Console.WriteLine("haftaiçi");
                    break;            
                case 3:
                    Console.WriteLine("haftanin 3. günü carsamba");
                    Console.WriteLine("haftaiçi");
                    break;
                case 4:
                    Console.WriteLine("haftanin 4. günü persembe");
                    Console.WriteLine("haftaiçi");
                    break;
                case 5:
                    Console.WriteLine("haftanin 5. günü cuma");
                    Console.WriteLine("haftaiçi");
                    break;
                case 6:
                    Console.WriteLine("haftanin 6. günü cumartesi");
                    Console.WriteLine("haftasonu");
                    break;
                case 7:
                    Console.WriteLine("haftanin 7. günü pazar");
                    Console.WriteLine("haftasonu");
                    break;
                default:
                    Console.WriteLine("haftada 7 günden oluşur farkli bir sayi giriniz..");
                    goto basasar;
                    break;
            }   
        }
    }
}