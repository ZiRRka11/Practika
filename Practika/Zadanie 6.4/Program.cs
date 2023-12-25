using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите положительное число а: ");
        int number = Convert.ToInt32(Console.ReadLine());

        while (number >= 0)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма всех делителей числа {number} равна {sum}.");
            Console.Write("Введите новое положительное число а: ");
           
        }
    }
}