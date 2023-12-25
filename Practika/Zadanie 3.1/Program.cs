using System;


class Program
{
    static void Main()
    {
        string inputFileName = @"C:\\Users\\ZeRRo\\RiderProjects\\Practika\\Zadanie 3.1\\input.txt";
        string outputFileName = @"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 3.1\output.txt";

        
        string[] lines = File.ReadAllLines(inputFileName);
        int[] chosenNumbers = lines[0].Split(' ').Select(int.Parse).ToArray();

        int numberOfTickets = int.Parse(lines[1]);

        using (StreamWriter writer = new StreamWriter(outputFileName))
        {
            for (int i = 0; i < numberOfTickets; i++)
            {
                string ticket = string.Join(" ", File.ReadAllText(inputFileName).Split('\n')[2 + i].Split(' '));
                int count = chosenNumbers.Count(num => ticket.Contains(num.ToString()));

                if (count >= 3)
                {
                    writer.WriteLine("Lucky");
                }
                else
                {
                    writer.WriteLine("Unlucky");
                }
            }
        }
    }
}