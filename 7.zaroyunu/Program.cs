using System;

class Craps
{
    private static Random RandomNumbers = new Random();

    private enum Status { Continue, Won, Lose }

    private enum DiceNames
    {
        SnakeEyes = 2,
        Trey = 3,
        Seven = 7,
        YoLeven = 11,
        Boxcars = 12
    }

    static void Main()
    {
        Console.WriteLine("Press Enter to roll the dice.");
        Console.ReadLine(); // Kullanıcıdan bir tuşa basmasını bekleyin

        Status gameStatus = Status.Continue;
        int mypoint = 0;
        int sumOfDice = RollDice();

        switch ((DiceNames)sumOfDice)
        {
            case DiceNames.Seven: // win with 7 on first roll
            case DiceNames.YoLeven: // win with 11 on first roll
                gameStatus = Status.Won;
                break;
            case DiceNames.SnakeEyes:
            case DiceNames.Trey:
            case DiceNames.Boxcars:
                gameStatus = Status.Lose;
                break;
            default:
                gameStatus = Status.Continue;
                mypoint = sumOfDice;
                Console.WriteLine($"Point is {mypoint}");
                break;
        }

        while (gameStatus == Status.Continue)
        {
            Console.WriteLine("Press Enter to roll the dice.");
            Console.ReadLine(); // Kullanıcıdan bir tuşa basmasını bekleyin

            sumOfDice = RollDice();

            if (sumOfDice == mypoint)
            {
                gameStatus = Status.Won;
            }
            else
            {
                if (sumOfDice == (int)DiceNames.Seven)
                {
                    gameStatus = Status.Lose;
                }
            }
        }

        if (gameStatus == Status.Won)
        {
            Console.WriteLine("Player wins");
        }
        else
        {
            Console.WriteLine("Player loses");
        }
    }

    static int RollDice()
    {
        int die1 = RandomNumbers.Next(1, 7);
        int die2 = RandomNumbers.Next(1, 7);

        int sum = die1 + die2;

        Console.WriteLine($"Player rolled {die1} + {die2} = {sum}");
        return sum;
    }
}