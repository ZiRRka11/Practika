using System;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 6.1\numsTask1.txt");
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            string[] words = line.Split(' ');
            foreach (string word in words)
            {
                if (word.Length % 2 != 0) 
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}