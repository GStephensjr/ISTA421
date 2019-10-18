using System;

namespace decbinoctConversion
{
    class Bin
    {
        public static void Dec2Bin(int input)
        {
            int factor = 1;
            int result = 0;
            while (input > 0)
            {
                int digit = (input % 2) * factor;
                result += digit;
                factor *= 10;
                input /= 2;
            }
            System.Console.WriteLine($"Your binary is {result}");

            Program.Reset();

        }
        public static void Oct2Bin(int input)
        {
            int factor = 1;
            int result = 0;
            while (input > 0)
            {
                int digit = (input % 8) * factor;
                result += digit;
                factor *= 10;
                input /= 8;
            }
            Console.WriteLine($"Your binary is {result}");
            Program.Reset();

        }

    }
}
