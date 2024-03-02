using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, -3, 4, -5, 6, 7, -8, 9 };

        // Знаходимо кількість від'ємних елементів
        int negativeCount = numbers.Count(n => n < 0);

        // Знаходимо суму від'ємних елементів
        int negativeSum = numbers.Where(n => n < 0).Sum();

        // Виводимо результат
        Console.WriteLine(negativeCount > 0 ? $"Кількість від'ємних елементів: {negativeCount}, сума: {negativeSum}" : "0 0");
    }
}
