using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputFileName = @"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 5.2\numsTask2.txt";
        string outputFileName = @"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 5.2\numsTask2.txt";

        List<double> numbers = new List<double>();

        using (StreamReader reader = new StreamReader(inputFileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] numbersInLine = line.Split(';');
                foreach (string numberString in numbersInLine)
                {
                    double number;
                    if (double.TryParse(numberString, out number))
                    {
                        numbers.Add(number);
                    }
                }
            }
        }

        numbers.Sort();

        using (StreamWriter writer = new StreamWriter(outputFileName))
        {
            foreach (double number in numbers)
            {
                writer.WriteLine(number);
            }
        }
    }
}