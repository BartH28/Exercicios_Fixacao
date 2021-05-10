using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i < 11; i++)
            {
                Console.WriteLine($@"Tabuada do {i}");
                for (var j = 1; j < 11; j++)
                { 
                    int mult = i * j;
                    Console.WriteLine($@"{i} x {j} = {mult}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("www.twitch.tv/p0rto__");
            Console.ResetColor();
        }
    }
}
