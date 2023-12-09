using System;


class Program{

    static void Main(string[] args){

        int[] sayilar = new int[10];

        for(int i=0 ; i<10 ; i++){
            Console.WriteLine($"lütfen {i+1}. sayiyi giriniz : ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int a=0 ; a<10 ; a++){
            Console.WriteLine((a+1) + ".sayi : " + (sayilar[a]));
        }
        int enbuyuk = sayilar.Max();

        Console.WriteLine($"en büyük sayi : {enbuyuk}");
    }

}