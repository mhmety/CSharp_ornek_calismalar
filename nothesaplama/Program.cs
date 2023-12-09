using System;

class Mystery2
{
    public static void Main()
    {
        int number = 50; //girilen number değişkeni
        while (number >= 40) //girilen değer verilen koşul tamamlanana kdar döngüye alınıyor
        {       
            Console.WriteLine(number * 100/50 > 90? "A*" : "B"); //döngü boyunca işlem sonucuna göre çıktısı belirleniyor.
            --number;
        }
    }
}