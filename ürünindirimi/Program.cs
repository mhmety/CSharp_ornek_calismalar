using System;

class Program{

    static void Main(string[] args){

        const double indirim1 = 0.10;
        const double indirim2 = 0.20;
        const double alimsiniri = 5000.0;

        Console.WriteLine("alinan ürün sayisini giriniz: ");
        int ürünsayisi = int.Parse(Console.ReadLine());

        double toplamürünmiktari=0.0;
        
        for(int i=1;i<=ürünsayisi;i++){
            Console.WriteLine($"Lütfen {i}. ürünün fiyatini giriniz: ");
            double ürünfiyati = double.Parse(Console.ReadLine());

            toplamürünmiktari += ürünfiyati;
        }

        double indirimtutari = 0.0;

        if(toplamürünmiktari<alimsiniri){
            
            indirimtutari = toplamürünmiktari * indirim1;
        }
        else{
            indirimtutari = toplamürünmiktari * indirim2;
        }
        double ödememiktari = toplamürünmiktari - indirimtutari;

        Console.WriteLine($"alişveriş tutari : {toplamürünmiktari}");
        Console.WriteLine($"indirim miktari : {indirimtutari}");
        Console.WriteLine($"ödenecek tutar: {ödememiktari}");
    }
}