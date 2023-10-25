using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace EvCekilisi{
    class Program{

        static void Main(string[] args){

            Console.WriteLine("Ev çekilişi programina hoşgeldiniz");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("çekilişe katilacak kişi sayisini belirleyiniz: ");
            string deger = Console.ReadLine();
            int kisisayisi= Convert.ToInt32(deger);
            string[] kisiler= new string[kisisayisi];

            for (int i = 0; i < kisisayisi; i++)
            {   Console.WriteLine((i+1) + ". kisinin adini giriniz");
                kisiler[i] = Console.ReadLine();
            }
            Console.WriteLine("çekilişte çikacak talihli sayisini belirleyiniz: ");
            string Deger = Console.ReadLine();
            int talihlisayisi= Convert.ToInt32(Deger);

            Random rastgele= new Random(); //rastgele sayı tanımlamak için

            for (int i = 0; i < talihlisayisi; i++){
               
                int talihli= rastgele.Next(kisisayisi-1);
                Console.WriteLine("Tebrikler kazanan isim: "+ kisiler[talihli]);}
        }            
                
    }
} 