using System;


class Program
{
    static void Main()
    {
        string inputFile = @"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 3.2\nums.txt";
        string outputFile = @"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 3.2\output.txt";

        using (StreamReader reader = new StreamReader(inputFile))
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] numbers = line.Split(' ');
                bool isOdd = false;

                foreach (string number in numbers)
                {
                    int num;
                    if (int.TryParse(number, out num))
                    {
                        if (num % 2 != 0)
                        {
                            isOdd = true;
                            writer.Write(number + " ");
                        }
                    }
                }

                if (isOdd)
                {
                    writer.Write("\n");
                }

                line = reader.ReadLine();
            }
        }

        Console.WriteLine("Output file: " + outputFile);
    }
}