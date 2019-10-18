using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> print = from x in n1
                                     where x % 2 == 0
                                     select x;
            foreach (int x in print)
                Console.WriteLine(x);
            Console.WriteLine();


            int[] n2 = new int[13] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //IEnumerable<int> print2 = from x in n2
            //                          where x > 0 && x < 12
            //                          select x;
            IEnumerable<int> print2 = n2.Where(x => x > 0 && x < 12);
            foreach (int x in print2)
                Console.WriteLine(x);


            Console.WriteLine();
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            IEnumerable<int> print3 = from x in arr1
                                      where x * x > 20
                                      select x;
            foreach (int x in print3)
                Console.WriteLine($"Number = {x}, SqrNo = {x * x}");
            Console.WriteLine();

            int[] arr2 = new int[18] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            IEnumerable<int> print4 = arr2.Distinct();
            int print44 = print4.Distinct().Count();
            Dictionary<IEnumerable<int>, int> list = new Dictionary<IEnumerable<int>, int>();
            list.Add(print4, print44);

            foreach (KeyValuePair<IEnumerable<int>, int> x in list)
                Console.WriteLine($"{x.Key}, {x.Value}");

            //    arr2.Distinct();
            //int print44 = arr2.Distinct().Count();
            //foreach (int x in print4)
            //    Console.WriteLine($"{x}{x}");



        }
    }
}
