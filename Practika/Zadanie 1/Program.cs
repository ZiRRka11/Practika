using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        Random random = new Random();


        for (int i = 0; i < 10; i++)
        {
            numbers[i] = random.Next(1, 100);
        }
        int MinValue = int.MaxValue;
        int minIndex = 0;
        
        for(int i =0; i < numbers.Length; i++)
        { 
            if (numbers[i] < MinValue)
            {
                MinValue = numbers[i];
                minIndex = i;
            }
        }

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("Индекс минимального элемента: " + minIndex);
    }
}
