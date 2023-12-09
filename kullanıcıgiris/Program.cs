using System;

class Program{
    static void Main(string[] args){

        int kullanicisecimi = 0;

        while(true){
            Console.WriteLine("lütfen 1 veya 2 giriniz: ");
            string kullanicigirisi = Console.ReadLine();


            if(int.TryParse(kullanicigirisi, out kullanicisecimi)){

                if(kullanicisecimi==1 || kullanicisecimi==2){
                    break;
                }
                else{
                    Console.WriteLine("geçersiz giriş.Lütfen tekrar deneyiniz.");
                }
            }
            else{
                Console.WriteLine("geçersiz giriş.Lütfen tekrar deneyiniz.");

            }           
        }

        Console.WriteLine($"Seçilen Değer : {kullanicisecimi}");
    }
}