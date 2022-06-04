using System;

namespace Fib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonachi1(11));
        }

        public static int Fibonachi1(int steps)
        {
            int current = 1;
            int previous = 0;

            if (steps == 0)
                return 0;
            else if (steps == 1)
                return 1;

            for (int i = 2; i < steps; i++)
            {
                var tmp = current;
                current += previous;
                previous = tmp;
            }

            return current;
        }
    }
}
