using System;

class Program
{
     static void Main (string[] args)
     {
        int count = 0;
        using (StreamReader sr = new StreamReader(@"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 4.4\numsTask4.txt")) {
            string line;
            while ((line = sr.ReadLine()) != null) 
            {
                string[] numbers = line.Split(' ');
                for (int i = 0; i < numbers.Length - 1; i++) 
                {
                    if (numbers[i] == numbers[i + 1]) 
                    {
                        count++;
                    }
                }
            }
        }
        Console.WriteLine("Количество одинаковых рядом стоящих чисел: " + count);
    }
}