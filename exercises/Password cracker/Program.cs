using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCracker
{

    class Program
    {
        public static string password;
        public static int[] referenceTable = Enumerable.Range(33, 126).ToArray();
        //public static List<char> cracked = new List<char>();
        public static StringBuilder cracked = new StringBuilder(string.Empty, 255);
        public static int len;
        public static int acc = 1;
        static void Main()
        {
            Console.Write("Please input a password: ");
            password = Console.ReadLine();
            len = password.Length;
            passBreak();
            Reset();
        }


        private static void passCrack()
        {

        }



        private static void passBreak()
        {
            cracked.Clear();
            for (int i = 0; i < len; i++)
                cracked.Append(Convert.ToChar(referenceTable[acc]));
            if (password == cracked.ToString())
            {
                Console.WriteLine($"cracked password is {cracked.ToString()}");
                Reset();
            }

            else
            {
                int[] addendum = Enumerable.Range(33, 126).ToArray();
                List<char> addon = new List<char>();
                for (int i = 0; i < referenceTable.Length; i++)
                {
                    for (int j = 0; j < addendum.Length; j++)
                    {
                        cracked.Append(Convert.ToChar(referenceTable[i] + Convert.ToChar(addendum[j])));
                        cracked.Append(Convert.ToChar(addendum[j] + Convert.ToChar(referenceTable[i])));
                        foreach(int k in referenceTable)
                            addon.Add(Convert.ToChar(k));
                        foreach(int k in addendum)
                            addon.Add(Convert.ToChar(k));
                        foreach (char c in addon)
                        {
                            cracked.Clear();
                            cracked.Append(c);
                            if (password == cracked.ToString())
                            {
                                Console.WriteLine($"cracked password is {cracked.ToString()}");
                                Reset();

                            }
                        }

                    }

                }
                foreach (char c in addon)
                    cracked.Append(c);
                ++acc;
                passBreak();
            }


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
        public static void directComparison()
        {
            for (int i = 0; i < password.Length; i ++)
            {
                foreach (int j in referenceTable)
                {
                    if (password[i] == Convert.ToChar(j))
                        cracked.Append(Convert.ToChar(j));
                }
            }
            Console.Write("the password is: [");
            foreach (char c in cracked.ToString())
                Console.Write(c);
            Console.WriteLine("]");

            Reset();

        }

    }
}
