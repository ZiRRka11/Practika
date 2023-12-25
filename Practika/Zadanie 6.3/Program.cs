using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0 && num % 10 == 0)
        {
            Console.WriteLine("Число является четным и кратным 10.");
        }
        else
        {
            Console.WriteLine("Число не является четным или не кратно 10.");
        }
    }
}