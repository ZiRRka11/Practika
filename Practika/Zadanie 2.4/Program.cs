using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[][] temperature = new int[12][];
        Random random = new Random();

        for (int month = 0; month < 12; month++)
        {
            temperature[month] = new int[30];
            for (int day = 0; day < 30; day++)
            {
                temperature[month][day] = random.Next(-20, 30);
            }
        }

        int[] averageTemperatures = CalcAverageTemperatures(temperature);
        List<int> sortedAverageTemperatures = new List<int>(averageTemperatures);
        sortedAverageTemperatures.Sort();

        for (int i = 0; i < sortedAverageTemperatures.Count; i++)
        {
            Console.WriteLine($"Средняя температура за месяц {i + 1}: {sortedAverageTemperatures[i] }°C");
        }
    } 

    static int[] CalcAverageTemperatures(int[][] temperature)
    {
        int[] averageTemperatures = new int[12];
        for (int month = 0; month < 12; month++)
        {
            int sum = 0;
            for (int day = 0; day < 30; day++)
            {
                sum += temperature[month][day];
            }
            averageTemperatures[month] = sum / 30;
        }
        return averageTemperatures;
    }
}