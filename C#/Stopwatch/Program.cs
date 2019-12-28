using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Watch.Start();
            Watch.End();
            Console.WriteLine("Duration 1: " + Watch.Duration);

            Watch.Start();
            Watch.End();
            Console.WriteLine("Duration 2: " + Watch.Duration);
        }
    }
}
