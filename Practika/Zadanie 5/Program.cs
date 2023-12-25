using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ', '\t', '\n');
        int Word = words.Length;
        
        Console.WriteLine($"Количество слов: {Word}");

        List<string> wordList = new List<string>(words);
        string result = $"Start {string.Join(" ", wordList)} End";
        Console.WriteLine(result);
    }
}