using System;

namespace EX03ConsolePlay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;
            Console.Beep(200, 1000);
        }
    }
}
