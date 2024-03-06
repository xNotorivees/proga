using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, -3, 4, -5, 6, 7, -8, 9 };

        int negativeCount = numbers.Count(n => n < 0);

        int negativeSum = numbers.Where(n => n < 0).Sum();

        Console.WriteLine(negativeCount > 0 ? $"Кількість від'ємних елементів: {negativeCount}, сума: {negativeSum}" : "0 0");
    }
}
