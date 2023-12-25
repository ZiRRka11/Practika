using System;


class Program
{
     static void Main ()
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        
        using (StreamReader sr = new StreamReader(@"C:\\Users\\ZeRRo\\RiderProjects\\Practika\\Zadanie 4.3\\numsTask3.txt")) 
        {
            string line;
            while ((line = sr.ReadLine()) != null) {
                string[] numbers = line.Split(',');
                foreach (string number in numbers) 
                {
                    int num = Convert.ToInt32(number);
                    if (num > 0 && num < min)
                    {
                        min = num;
                    }
                    if (num > max)
                    {
                        max = num;
                    }
                }
            }
        }
        double ratio = (double) max / min;
        Console.WriteLine("Отношение минимального и максимального элементов: " + ratio);
    }
}