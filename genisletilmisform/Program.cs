using System;   

class Program{
    static void Main(){

        while(true){
            
            Console.WriteLine("6 basamakli bir sayi giriniz:");
            string userinput = Console.ReadLine();

            if(userinput.Length==6 && int.TryParse(userinput, out int number)){

                Console.WriteLine("genişletilmiş form: ");

                int hane, yerdegeri, terimdegeri;

                for(int i = 0;i<userinput.Length;i++){

                    hane = int.Parse(userinput[i].ToString());
                    yerdegeri = (int)Math.Pow(10,userinput.Length - i - 1);
                    terimdegeri = hane * yerdegeri;

                    Console.WriteLine($"({hane}*{yerdegeri})");
                    if(i<userinput.Length - 1){
                        Console.Write("+");
                    }
                    else{
                        Console.WriteLine();

                    }
                }
                break;
            }
            else{
                Console.WriteLine("hatali giris yapildi lütfen 6 basamakli bir deger giriniz.");
            }
        }
    }

}