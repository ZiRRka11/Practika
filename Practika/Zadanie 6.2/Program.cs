using System;

class Program
{
    static void Main()
    {
       
        StreamReader reader = new StreamReader(@"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 6.2\numsTask2.txt");
        string line;
        string resultString = "";

        while ((line = reader.ReadLine()) != null)
        {
            resultString += line + " ";
        }
       
        if (!String.IsNullOrEmpty(resultString))
        {
            resultString = resultString.TrimEnd();
        }
        
        Console.WriteLine("Словосочетание: " + resultString);
    }
}