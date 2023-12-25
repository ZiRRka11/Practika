using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputFileName = @"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 5.3\numsTask3.txt";

        List<int> numbers = new List<int>();

        using (StreamReader reader = new StreamReader(inputFileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                int number;
                if (int.TryParse(line, out number))
                {
                    numbers.Add(number);
                }
            }
        }

        int minNumber = numbers[0];
        int sum = 0;

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
            sum += numbers[i];
        }

        double average = (double)sum / (double)(numbers.Count - 1);

        Console.WriteLine("Среднее арифметическое элементов, расположенных до минимального числа: " + average);
    }
}