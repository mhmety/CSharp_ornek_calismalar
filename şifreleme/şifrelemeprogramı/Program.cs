using System;

class Program
{
    static void Main()
    {
        Console.Write("Dört basamaklı bir tam sayı girin: ");
        int originalNumber;

        while (!int.TryParse(Console.ReadLine(), out originalNumber) || originalNumber < 1000 || originalNumber > 9999)
        {
            Console.Write("Geçerli bir dört basamaklı tam sayı girin: ");
        }

        int encryptedNumber = Encrypt(originalNumber);
        Console.WriteLine($"Şifrelenmiş sayı: {encryptedNumber:D4}");
    }

    static int Encrypt(int number)
    {
        int digit1 = (number + 7) % 10;
        int digit2 = (number / 1000 + 7) % 10;
        int digit3 = (number / 100 % 10 + 7) % 10;
        int digit4 = (number / 10 % 10 + 7) % 10;

        return digit2 * 1000 + digit1 * 100 + digit4 * 10 + digit3;
    }
}