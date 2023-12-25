using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int inputNumber;
        
        Console.WriteLine("Введите числа. Введите 0, чтобы закончить");

        while ((inputNumber = int.Parse(Console.ReadLine())) != 0)
        {
            numbers.Add(inputNumber);
        }

        int sum = 0;
        int product = 1;
        double average = 0;

        foreach (int number in numbers)
        {
            sum += number;
            product *= number;
            average += number;
        }

        average = sum / numbers.Count;

       
        Console.WriteLine("Сумма всех элементов списка: " + sum);
        Console.WriteLine("Произведение всех элементов списка: " + product);
        Console.WriteLine("Среднее значение всех элементов списка: " + average);
    }
}