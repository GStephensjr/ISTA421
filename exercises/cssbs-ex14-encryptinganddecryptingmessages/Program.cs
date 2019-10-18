using System;
using System.Collections.Generic;

namespace cssbs_ex14_encryptinganddecryptingmessages
{
    class Program
    {
        public static string ptext;
        public static string ctext;
        public static string cmtext;
        public static row[] table = new row[]
        {
            new row{character = 'a', integer = 1 },
            new row{character = 'b', integer = 2 },
            new row{character = 'c', integer = 3 },
            new row{character = 'd', integer = 4 },
            new row{character = 'e', integer = 5 },
            new row{character = 'f', integer = 6 },
            new row{character = 'g', integer = 7 },
            new row{character = 'h', integer = 8 },
            new row{character = 'i', integer = 9 },
            new row{character = 'j', integer = 10 },
            new row{character = 'k', integer = 11 },
            new row{character = 'l', integer = 12 },
            new row{character = 'm', integer = 13 },
            new row{character = 'n', integer = 14 },
            new row{character = 'o', integer = 15 },
            new row{character = 'p', integer = 16 },
            new row{character = 'q', integer = 17 },
            new row{character = 'r', integer = 18 },
            new row{character = 's', integer = 19 },
            new row{character = 't', integer = 20 },
            new row{character = 'u', integer = 21 },
            new row{character = 'v', integer = 22 },
            new row{character = 'w', integer = 23 },
            new row{character = 'x', integer = 24 },
            new row{character = 'y', integer = 25 },
            new row{character = 'z', integer = 26 },
            new row{character = '␣', integer = 27 },


        };
        public static List<int> pnumbers = new List<int>();
        public static int cnumber;
        public static List<int> cnumbers = new List<int>();
        public static List<char> encodedText = new List<char>();
        public static List<int> encodedInt = new List<int>();
        public static List<int> decodedInt = new List<int>();
        public static List<char> decodedText = new List<char>();

        public static List<char> encodedMultiText = new List<char>();
        public static List<int> encodedMultiInt = new List<int>();
        public static List<int> decodedMultiInt = new List<int>();
        public static List<char> decodedMultiText = new List<char>();



        static void Main()
        {
            boardClear();

            getInput();
            Encrypt();
            Decrypt();
            Reset();

        }

        private static void boardClear()
        {
            pnumbers.Clear();
            cnumber = 0;
            cnumbers.Clear();
            encodedText.Clear();
            encodedInt.Clear();
            decodedInt.Clear();
            decodedText.Clear();
            encodedMultiInt.Clear();
            encodedMultiText.Clear();
            decodedMultiInt.Clear();
            decodedMultiText.Clear();
        }

        private static void Decrypt()
        {
            //single char decoding
            foreach (int i in encodedInt)
            {

                if (i - cnumber < 0)
                    decodedInt.Add((i - cnumber) + 27);
                else
                    decodedInt.Add(i - cnumber);
            }
            foreach (int i in decodedInt)
            {
                foreach (row r in table)
                    if (i == r.integer)
                        decodedText.Add(r.character);
            }
            Console.WriteLine();
            Console.WriteLine("decoded text is: ");
            Console.Write("[");
            foreach (char c in decodedText)
                Console.Write(c);
            Console.Write("]");
            Console.WriteLine();

            //multi char decoding
            int acc = 0;

            foreach (int i in encodedMultiInt)
            {
                if (acc > cnumbers.ToArray().Length - 1)
                    acc = 0;
                if (i - cnumbers[acc] < 0)
                    decodedMultiInt.Add((i - cnumbers[acc]) + 27);
                else
                    decodedMultiInt.Add(i - cnumbers[acc]);
                acc++;
            }
            foreach (int i in decodedMultiInt)
            {
                foreach (row r in table)
                    if (i == r.integer)
                        decodedMultiText.Add(r.character);
            }
            Console.WriteLine();
            Console.WriteLine("decoded text with multi char cypher is: ");
            Console.Write("[");
            foreach (char c in decodedMultiText)
                Console.Write(c);
            Console.Write("]");
            Console.WriteLine();

        }

        private static void Encrypt()
        {
            foreach (char c in ptext)
            {
                foreach (row r in table)
                {
                    if (c == r.character)
                        pnumbers.Add(r.integer);
                }
            }
            foreach (char c in ctext)
            {
                foreach (row r in table)
                    if (c == r.character)
                        cnumber = r.integer;
            }
            foreach (char c in cmtext)
            {
                foreach (row r in table)
                    if (c == r.character)
                        cnumbers.Add(r.integer);
            }


            foreach (int n in pnumbers)
                Console.Write($"{n}, ");
            Console.WriteLine();
            Console.Write($"{cnumber}, ");
            Console.WriteLine();
            foreach (int n in cnumbers)
                Console.Write($"{n}, ");
            Console.WriteLine();

            //single char encoding
            foreach (int n in pnumbers)
            {
                if (n + cnumber > 27)
                    encodedInt.Add((n + cnumber) - 27);
                else
                    encodedInt.Add(n + cnumber);
            }
            foreach (int n in encodedInt)
            {
                foreach (row r in table)
                    if (n == r.integer)
                        encodedText.Add(r.character);
            }
            Console.WriteLine();
            Console.WriteLine("encoded text with single char cypher is: ");
            Console.Write("[");
            foreach (char c in encodedText)
                Console.Write(c);
            Console.Write("]");
            Console.WriteLine();

            //multi char encoding
            int acc = 0;

            foreach(int i in pnumbers)
            {
                if (acc > cnumbers.ToArray().Length - 1)
                    acc = 0;
                if (i + cnumbers[acc] > 27)
                    encodedMultiInt.Add((i + cnumbers[acc]) - 27);
                else
                    encodedMultiInt.Add(i + cnumbers[acc]);

               acc++;
            }
            foreach (int i in encodedMultiInt)
            {
                foreach (row r in table)
                    if (i == r.integer)
                        encodedMultiText.Add(r.character);
            }
            Console.WriteLine();
            Console.WriteLine("encoded text with multi char cypher is: ");
            Console.Write("[");
            foreach (char c in encodedMultiText)
                Console.Write(c);
            Console.Write("]");
            Console.WriteLine();



        }

        public static void getInput()
        {
            Console.Write("Please enter a phrase to be encoded: ");
            ptext = Console.ReadLine();
            Console.Write("Please enter a single character cypher: ");
            ctext = Console.ReadLine();
            Console.Write("Please enter a multiple character cypher: ");
            cmtext = Console.ReadLine();
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
    public class row
    {
        public char character { get; set; }
        public int integer { get; set; }
    }
}
