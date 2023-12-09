using System;

class Program
{
    static void Main()
    {
        Console.Write("Şifrelenmiş dört basamaklı bir tam sayı girin: ");
        int encryptedNumber;

        while (!int.TryParse(Console.ReadLine(), out encryptedNumber) || encryptedNumber < 1000 || encryptedNumber > 9999)
        {
            Console.Write("Geçerli bir dört basamaklı şifrelenmiş tam sayı girin: ");
        }

        int decryptedNumber = Decrypt(encryptedNumber);
        Console.WriteLine($"Çözülen sayı: {decryptedNumber:D4}");
    }

    static int Decrypt(int number)
    {
        int digit1 = (number % 100) / 10;
        int digit2 = (number % 10);
        int digit3 = (number / 1000);
        int digit4 = (number / 100) % 10;

        int originalNumber = (digit3 * 1000) + (digit1 * 100) + (digit4 * 10) + digit2;
        originalNumber -= 7;

        if (originalNumber < 1000)
        {
            originalNumber += 10000;
        }

        return originalNumber;
    }
}