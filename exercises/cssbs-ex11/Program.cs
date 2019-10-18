using System;
using System.Collections.Generic;
using System.Linq;

namespace cssbs_ex11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Two Dimensions or Three Dimensions? \n" +
                "1. Two Dimensions\n" +
                "2. Three Dimensions\n");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
                dimTwo();
            else if (choice == 2)
                dimThree();
            else
                Main();
        }

        private static void dimThree()
        {
            Random random = new Random();
            List<Vector> Vectors = new List<Vector>();
            for (double i = 0; i < 1000; i++)
            {
                Vectors.Add(new Vector(random.Next(0, 1000), random.Next(0, 1000), random.Next(0, 1000)));
            }
            Console.WriteLine($"Vector Count: {Vectors.Count()}");
            Console.WriteLine("Vectors are:");
            foreach (Vector p in Vectors)
                Console.WriteLine($"[{p.v1},{p.v2}, {p.v3}]");
            CompareDistanceThree(Vectors);
            Reset();
        }


        private static void dimTwo()
        {
            Random random = new Random();
            List<Vector> Vectors = new List<Vector>();
            for (double i = 0; i < 100; i++)
            {
                Vectors.Add(new Vector(random.Next(0, 100), random.Next(0, 100)));
            }
            Console.WriteLine($"Vector Count: {Vectors.Count()}");
            Console.WriteLine("Vectors are:");
            foreach (Vector p in Vectors)
                Console.WriteLine($"[{p.v1},{p.v2}]");
            compareDistanceTwo(Vectors);
            Reset();

        }
        private static void compareDistanceTwo(List<Vector> Vectors)
        {
            List<double> distances = new List<double>();
            foreach (Vector p in Vectors)
            {
                foreach (Vector i in Vectors)
                {
                    double addon = Math.Sqrt(Math.Pow((p.v1 - i.v1), 2) + Math.Pow((p.v2 - i.v2), 2));
                    if (addon != 0)
                        distances.Add(addon);
                }
            }
            double result = distances.Min();
            //Console.WriteLine("{0}", result);

            Console.WriteLine("The closest vectors are: ");
            foreach (Vector p in Vectors)
            {
                foreach (Vector i in Vectors)
                {
                    double addon = Math.Sqrt(Math.Pow((p.v1 - i.v1), 2) + Math.Pow((p.v2 - i.v2), 2));
                    if (addon == result)
                        Console.WriteLine($"[{p.v1}, {p.v2}] and [{i.v1}, {i.v2}]");
                }
            }
            Console.WriteLine($"With a distance of {result}");

            //Console.WriteLine(distances.Count());
            //foreach (double d in distances)
            //{
            //    Console.WriteLine(d);
            //}
        }

        private static void CompareDistanceThree(List<Vector> Vectors)
        {
            List<double> distances = new List<double>();
            foreach (Vector p in Vectors)
            {
                foreach (Vector i in Vectors)
                {
                    double addon = Math.Sqrt(Math.Pow((p.v1 - i.v1), 2) + Math.Pow((p.v2 - i.v2), 2) + Math.Pow((p.v3 - i.v3), 2));
                    if (addon != 0)
                        distances.Add(addon);
                }
            }
            double result = distances.Min();
            //Console.WriteLine("{0}", result);

            Console.WriteLine("The closest vectors are: ");
            foreach (Vector p in Vectors)
            {
                foreach (Vector i in Vectors)
                {
                    double addon = Math.Sqrt(Math.Pow((p.v1 - i.v1), 2) + Math.Pow((p.v2 - i.v2), 2) + Math.Pow((p.v3 - i.v3), 2));
                    if (addon == result)
                        Console.WriteLine($"[{p.v1}, {p.v2}, {p.v3}] and [{i.v1}, {i.v2}, {i.v3}]");
                }
            }
            Console.WriteLine($"With a distance of {result}");
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
