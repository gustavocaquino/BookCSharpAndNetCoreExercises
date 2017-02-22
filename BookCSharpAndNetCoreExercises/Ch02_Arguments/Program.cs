using System;

namespace Ch02_Arguments
{
    using static Console;

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} arguments.");

            foreach (string arg in args)
                WriteLine(arg);

            ReadKey();
        }
    }
}
