using System;

namespace denklem{

    class Program{

        static void Main(string[] args);
        /* Bu denklemlerin C# daki karşılıklarını yazalım..
        a) y = 2ab + 2ac                =  y = (2*a*b) + (2*a*c)
        b) z = x (1 + x) - y (1 + y)    =  z = (x*(1+x)) - (y*(1+y)) 
        c) x = xy ÷ 3                   =  x = x*y / 3
        d) y = 4ab ÷ (4a + 4b)          =  y = (4*a*b) / ((4*a)(4*b))
        e) z = xa3 + yb3                =  z = (x*a*3) + (y*b*3)
        f) x = ac (bd) 4                =  x = a*c*(b*d)*4
        */


        /* Denklemde işlemlerin sıralanması
        a) x = 7 + 3 * 6 / 2 - 1;     öncelik çarpma-bölme-toplama ve çıkarma olarak alacaktır 
        cevap: 15
        b) x = 2 % 2 + 2 * 2 - 2 / 2;  öncelik olarak yüzde-çarpma-bölme-toplama ve çıkarma alacaktır
        cevap: 3,04
        c) x = (3 * 9 * (3 + (9 * 3 / (3))));  öncelil olarak en içteki parantezden başlayarak dışa doğru işlemleri gerçekleştirecektir
        cevap: 2268
        */
    }

}