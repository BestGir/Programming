using System;
class Program
{
    static void Main()
    {
        //Console's color
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Magenta;
        //Reading the name
        string surname = Console.ReadLine();
        string name = Console.ReadLine();
        string middleName = Console.ReadLine();
        //Data output 
        Console.WriteLine($"Здравствуйте, {surname} {name} {middleName}!");
        //Restoring console values
        Console.ResetColor();

    }
}
