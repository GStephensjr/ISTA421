using System;


namespace decbinoctConversion
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(
                "***************************************\n" +
                "What type of input is this?\n" +
                "1. Decimal\n" +
                "2. Binary\n" +
                "3. Octal\n" +
                "***************************************");
            int type = int.Parse(Console.ReadLine());

            Console.WriteLine(
                "***************************************\n" +
                "How do you want to convert?\n" +
                "1. Decimal\n" +
                "2. Binary\n" +
                "3. Octal\n" +
                "***************************************");
            int conversion = int.Parse(Console.ReadLine());
            if (conversion == 1)
                decConvert(input, type);
            else if (conversion == 2)
                binConvert(input, type);
            else if (conversion == 3)
                octConvert(input, type);
            else
                Reset();

        }

        private static void octConvert(int input, int type)
        {
            if (type == 1)
                Oct.Dec2Oct(input);
            else if (type == 2)
                Oct.Bin2Oct(input);
            else if (type == 3)
            {
                Console.WriteLine("unit is already octal");
                Reset();
            }
        }


        private static void binConvert(int input, int type)
        {
            if (type == 1)
                Bin.Dec2Bin(input);
            else if (type == 2)
            {
                Console.WriteLine("unit is already binary");
                Reset();
            }
            else if (type == 3)
                Bin.Oct2Bin(input);

        }

        private static void decConvert(int input, int type)
        {
            if (type == 1)
            {
                Console.WriteLine("unit is already decimal");
                Reset();
            }
            else if (type == 2)
                Dec.Bin2Dec(input);
            else if (type == 3)
                Dec.Oct2Dec(input);
        }
        public static void Pause()
        {
            Console.Write("Press any key to continue . . .");
            Console.ReadKey(true);
        }
        public static void Reset()
        {
            Pause();
            Console.Clear();
            Main();
        }

    }
}
