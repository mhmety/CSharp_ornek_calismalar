using System;

class Program{
    static void Main(){
        int uzunluk;
        int genislik;

        while(true){

            Console.WriteLine("lütfen 1-15 arasi bir uzunluk giriniz : ");
            uzunluk = Convert.ToInt32(Console.ReadLine());

            if(uzunluk >=1 && uzunluk  <=15){
                break;
            }
            else{
                Console.WriteLine("1-15 arası bir değer giriniz.");
            }
        }

        while(true){

            Console.WriteLine("lütfen 1-10 arasi bir genislik giriniz : ");
            genislik = Convert.ToInt32(Console.ReadLine());

            if(genislik >=1 && genislik <=10){
                break;
            }
            else{
                Console.WriteLine("1-10 arasi bir değer giriniz.");
            }
        }

        DrawRectangle(uzunluk, genislik);
    }
    static void DrawRectangle(int length, int width){

        for(int i=0 ; i<width ; i++)
        {
            
            for(int j=0; j<length;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
}
