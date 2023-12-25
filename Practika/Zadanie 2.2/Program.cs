using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<int> collection = new List<int>();
        int Value = 1;

        for (int i = 0; i < 50; i++)
        {
            collection.Add(Value);
            Value += 2;
        }

        foreach (int num in collection)
        {
            Console.Write(num + " ");
        }
    }
}