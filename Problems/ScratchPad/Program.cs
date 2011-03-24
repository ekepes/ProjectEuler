using System;
using System.Collections.Generic;

namespace ScratchPad
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DumpList(GetFactors(10));

            DumpList(GetFactors(21));

            DumpList(GetFactors(13195));

            Console.WriteLine("Done.");
            Console.ReadLine();
        }

        private static void DumpList<T>(List<T> list)
        {
            if (list == null)
            {
                Console.WriteLine("Null List");
                return;
            }
            foreach (T i in list)
            {
                Console.Write("{0},", i);
            }

            Console.WriteLine();
        }

        private static List<int> GetFactors(int value)
        {
            if (value == 1)
            {
                return new List<int> {1};
            }

            int i = 2;
            int limit = value/2;
            while (i < limit)
            {
                if (value%i == 0)
                {
                    List<int> factors = GetFactors(value/i);
                    factors.Add(i);

                    return factors;
                }
                i++;
            }

            return new List<int> {value};
        }
    }
}