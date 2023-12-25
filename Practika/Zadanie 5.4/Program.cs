using System;

class Program
{
    static void Main()
    {
       
        StreamReader reader = new StreamReader(@"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 5.4\numsTask4.txt");
        
        string[] numbersString = reader.ReadLine().Split(' ');
        int[] numbers = new int[numbersString.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersString[i]);
        }
        
        int max = numbers.Max();
        
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == max - 1)
            {
                sum += numbers[i];
            }
        }
        
       
        Console.WriteLine("Сумма элементов, отличающихся от максимального на 1: " + sum);
    }
}