using System;

namespace Ch03_CastingConverting
{
    using static Console;
    using static Convert;

    class Program
    {
        static void Main(string[] args)
        {
            // Cast examples:

            int a = 10;
            double b = a;

            WriteLine(b);

            double c = 9.8;
            int d = (int)c; // without the explicit cast, the compiler gives an error for this line.

            WriteLine(d);

            long e = 10;
            int f = (int)e;

            WriteLine($"e is {e} and f is {f}");

            e = long.MaxValue;
            f = (int)e; // beware that you might lose information because any value too big will get set to -1! 

            WriteLine($"e is {e} and f is {f}");

            // Convert examples:

            double g = 9.8;
            int h = ToInt32(g);

            WriteLine($"g is {g} and h is {h}");

            double i = 9.49;
            double j = 9.5;
            double k = 10.49;
            double l = 10.5;

            /*
             * Banker's Rounding:
             * the number is rounded up if the decimal part is .5 or higher and the non-decimal part is odd,
             * but it will round down if the non-decimal part is even.
             */
            WriteLine($"i is {i}, ToInt(i) is {ToInt32(i)}");
            WriteLine($"j is {j}, ToInt(j) is {ToInt32(j)}");
            WriteLine($"k is {k}, ToInt(k) is {ToInt32(k)}");
            WriteLine($"l is {l}, ToInt(l) is {ToInt32(l)}");

            ReadKey();
        }
    }
}
