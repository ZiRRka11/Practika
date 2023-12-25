using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начало диапазона:");
        int start = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите конец диапазона:");
        int end = int.Parse(Console.ReadLine());

        int[] randomNumbers = GenerateRandomNumbers(start, end);
        string numbersString = string.Join(" ", randomNumbers);

        Console.WriteLine( numbersString);
    }

    static int[] GenerateRandomNumbers(int start, int end)
    {
        Random random = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(start, end + 1);
        }

        return numbers;
    }
}