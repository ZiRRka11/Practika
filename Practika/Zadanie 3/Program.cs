using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> words = new List<string>();
        
        
        Console.WriteLine("Введите элементы. Введите пустую строку, чтобы закончить");
        while (true)
        {
            string inputWord = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputWord))
            {
                break;
            }
            words.Add(inputWord);
        }

        string shortestWord = words[0];
        string longestWord = words[0];

        if (words.Count > 0)
        {
            shortestWord = words[0];
            longestWord = words[0];
        }

        for (int i = 1; i < words.Count; i++)
        {
            if (words[i].Length < shortestWord.Length)
            {
                shortestWord = words[i];
            }
            if (words[i].Length > longestWord.Length)
            {
                longestWord = words[i];
            }
        }

        Console.WriteLine("Самое короткое слово в списке: " + shortestWord);
        Console.WriteLine("Самое длинное слово в списке: " + longestWord);
    }
}
