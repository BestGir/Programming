using System;

class Program
{
    static void Main()
    {
        //Reading data
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        //Data output 
        Console.WriteLine($"Гипотенуза равна {Math.Sqrt(a*a+b*b)}");
    }
}
