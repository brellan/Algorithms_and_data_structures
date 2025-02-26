using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            int TryCount = 0;
            int GameCount = 0;
            Random random = new Random();
            ConsoleKeyInfo tmp;
            do
            {
                GameCount++;
                int number = random.Next(1, 101);
                int AttemptCount = 0;
                while (true)
                {
                    AttemptCount++;
                    Console.WriteLine("Enter your try in [1;100]");
                    int tries = 0;
                    while (!int.TryParse(Console.ReadLine(), out tries)
                        || tries < 1 || tries > 100)
                        Console.WriteLine("Error. Enter correct number in [1;100]");
                    if (tries > number)
                        Console.WriteLine("Your try is more");
                    else if (tries < number)
                        Console.WriteLine("Your try is less");
                    else
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                }
                TryCount += AttemptCount;
                if (max < AttemptCount) max = AttemptCount;

                min = min == 0 || min > AttemptCount ? AttemptCount : min;
                Console.WriteLine("Enter Y if you want to play again.");
                tmp = Console.ReadKey();
            } while (tmp.Key == ConsoleKey.Y);
            Console.WriteLine($"Max = {max}\nMin = {min}\nAvg = {TryCount * 1.0 / GameCount}");
        }
    }
}
