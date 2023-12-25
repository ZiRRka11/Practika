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

        Dictionary<string, List<int>> averageTemperatures = CalcAverageTemperatures(temperature);

        foreach (var month in averageTemperatures)
        {
            Console.WriteLine($"Средняя температура за месяц {month.Key}: {month.Value.Average():F2}°C");
        }
    } 

    static Dictionary<string, List<int>> CalcAverageTemperatures(int[][] temperature)
    {
        Dictionary<string, List<int>> averageTemperatures = new Dictionary<string, List<int>>();
        string[] monthNames = new string[] { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };

        for (int month = 0; month < 12; month++)
        {
            List<int> monthTemperatures = new List<int>();
            for (int day = 0; day < 30; day++)
            {
                monthTemperatures.Add(temperature[month][day]);
            }
            averageTemperatures.Add(monthNames[month], monthTemperatures);
        }
        return averageTemperatures;
    }
}