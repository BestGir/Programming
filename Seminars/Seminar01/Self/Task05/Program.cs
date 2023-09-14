using System;
class Program
{
    static void Main()
    {
        //Reading data
        double U = double.Parse(Console.ReadLine());
        double R = double.Parse(Console.ReadLine());
        //Data output 
        Console.WriteLine($"I = {(U/R)} \nP = {U*U/R}");
    }
}