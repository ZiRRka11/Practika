using System;

class Program
{
    static void Main()
    {
        
        StreamReader reader = new StreamReader(@"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 5.5\numsTask5.txt");
        string[] numbersString = reader.ReadLine().Split(' ');
        int[] numbers = new int[numbersString.Length];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersString[i]);
        }
        
        int min = numbers.Min();
        int max = numbers.Max();
        
        int minIndex = 0;
        int maxIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == min)
            {
                minIndex = i;
            }

            if (numbers[i] == max)
            {
                maxIndex = i;
            }
        }
        
        int sum = 0;
        for (int i = minIndex + 1; i < maxIndex; i++)
        {
            sum += numbers[i];
        }
        
        double average = sum / (maxIndex - minIndex - 1);
        
        Console.WriteLine("Среднее арифметическое элементов между минимальным и максимальным: " + average);
        
    }
}