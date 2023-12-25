using System;


class Program
{
    static void Main ()
    {
        double sum = 0;
        using (StreamReader sr = new StreamReader(@"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 4.2\numsTask2.txt")) 
        { 
            string line;
            while ((line = sr.ReadLine()) != null) {
         
                string[] numbers = line.Split(';');
                
                foreach (string number in numbers)
                {
                    double num = Convert.ToDouble(number);
                    if (num > 0) 
                    {
                        sum += num;
                    }
                }
            }
        }
        Console.WriteLine("Сумма положительных элементов последовательности: " + sum);
    }
}