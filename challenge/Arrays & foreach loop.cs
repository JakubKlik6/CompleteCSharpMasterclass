using MembersC;
using System;
using System.ComponentModel;

namespace completeMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);

            Console.Read();

        }

        public static void GetOdd(int[] Array)
        {
            foreach (int oddNumber in Array)
            {
                if (oddNumber % 2 != 0)
                {
                    Console.WriteLine("Odd Numbers {0}", oddNumber);
                }
                else
                    continue;
            }
        }

        public static void GetEven(int[] Array)
        {
            foreach (int evenNumber in Array)
            {
                if (evenNumber % 2 == 0)
                {
                    Console.WriteLine("Even Numbers {0}", evenNumber);
                }
                else
                    continue;
            }
        }
    }
}
