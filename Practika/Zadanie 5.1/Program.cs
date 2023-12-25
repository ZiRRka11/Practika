using System;


class Program
{
    public static void Main () 
    {
        int min = int.MaxValue;
        int result = 1;
        using (StreamReader sr = new StreamReader(@"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 5.1\numsTask1.txt"))
        {
            string line;
            
            while ((line = sr.ReadLine()) != null) {
                int num = Convert.ToInt32(line);
                
                if (num < min) {
                    min = num;
                }
            }
        }
        
        using (StreamReader sr = new StreamReader(@"C:\Users\ZeRRo\RiderProjects\Practika\Zadanie 5.1\numsTask1.txt")) {
            string line;
            int index = 0;
            while ((line = sr.ReadLine()) != null) {
                int num = Convert.ToInt32(line);
                
                if (index >= min) {
                    result *= num;
                }
                
                index++;
            }
        }
        
        Console.WriteLine("Произведение элементов, расположенных после минимального: " + result);
    }
}