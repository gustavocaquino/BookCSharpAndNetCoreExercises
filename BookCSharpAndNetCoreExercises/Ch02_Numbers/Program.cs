using System;

namespace Ch02_Numbers
{
    using static Console;

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"sbyte uses {sizeof(sbyte)} bytes and can store numbers in the range {sbyte.MinValue:N0} to {sbyte.MaxValue:N0}.{Environment.NewLine}");
            WriteLine($"byte uses {sizeof(byte)} bytes and can store numbers in the range {byte.MinValue:N0} to {byte.MaxValue:N0}.{Environment.NewLine}");
            WriteLine($"ushort uses {sizeof(ushort)} bytes and can store numbers in the range {ushort.MinValue:N0} to {ushort.MaxValue:N0}.{Environment.NewLine}");
            WriteLine($"short uses {sizeof(byte)} bytes and can store numbers in the range {short.MinValue:N0} to {short.MaxValue:N0}.{Environment.NewLine}");
            WriteLine($"uint uses {sizeof(uint)} bytes and can store numbers in the range {uint.MinValue:N0} to {int.MaxValue:N0}.{Environment.NewLine}");
            WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.{Environment.NewLine}");
            WriteLine($"ulong uses {sizeof(ulong)} bytes and can store numbers in the range {ulong.MinValue:N0} to {ulong.MaxValue:N0}.{Environment.NewLine}");
            WriteLine($"long uses {sizeof(long)} bytes and can store numbers in the range {long.MinValue:N0} to {long.MaxValue:N0}.{Environment.NewLine}");
            WriteLine($"float uses {sizeof(float)} bytes and can store numbers in the range {float.MinValue:N0} to {float.MaxValue:N0}.{Environment.NewLine}");
            WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.{Environment.NewLine}");
            WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.{Environment.NewLine}");
            ReadKey();

            /*
             * The double type is NOT guaranteed to be accurate. 
             * Only use double when accuracy, especially when comparing two numbers, 
             * is not important, for example, when measuring a person's height.  
             */

            var a = 0.1M;  // M indicates a decimal literal value 
            var b = 0.2M;

            if (a + b == 0.3M)
                WriteLine($"{Environment.NewLine}{a} + {b} equals 0.3");
            else
                WriteLine($"{a} + {b} does NOT equal 0.3");

            ReadKey();
        }
    }
}
