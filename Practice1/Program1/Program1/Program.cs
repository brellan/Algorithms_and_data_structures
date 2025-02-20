using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = SumOfDigitsOfNumber(1, 100);
            Console.WriteLine(res);
        }
        // метод, который возвращает сумму четных цифр чисел в промежутке от 1 до 100
        static int SumOfDigitsOfNumber(int left, int right)
        {
            int sum = 0;
            for (int number = left; number <= right; number += 1)
            {
                int tmp = Math.Abs(number);
                while (tmp > 0)
                {
                    if (tmp % 2 == 0)
                        sum += tmp % 10;
                    tmp /= 10;
                }
            }
            return sum;
        }
    }
}
