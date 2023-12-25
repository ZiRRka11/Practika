using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int n = random.Next(1, 10); 
        
        double[] array = new double[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(-100, 100);
        }

        Console.WriteLine("Исходный массив:");
        foreach (double value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        double[] positiveArray = new double[n];
        double[] negativeArray = new double[n];

        int positiveCount = 0;
        int negativeCount = 0;

        for (int i = 0; i < n; i++)
        {
            if (array[i] > 0)
            {
                positiveArray[positiveCount++] = array[i];
            }
            else if (array[i] < 0)
            {
                negativeArray[negativeCount++] = array[i];
            }
        }
        Console.WriteLine("Массив с положительными элементами:");
        foreach (double value in positiveArray)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Массив с отрицательными элементами:");
        foreach (double value in negativeArray)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}