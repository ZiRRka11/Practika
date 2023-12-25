using System;

class Program
{
    static void Main () 
    {
        
        Console.WriteLine("Введите вещественное число a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите вещественное число b:");
        double b = Convert.ToDouble(Console.ReadLine());
        
        if ((-1 <= a) && (a <= 1) && (-3 <= b) && (b <= 2)) 
        {
            Console.WriteLine("Точка с координатами (" + a + "; " + b + ") принадлежит заштрихованной области.");
        } else 
        {
            Console.WriteLine("Точка с координатами (" + a + "; " + b + ") не принадлежит заштрихованной области.");
        }
    }
}