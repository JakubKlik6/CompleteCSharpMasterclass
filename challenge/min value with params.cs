using MembersC;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace completeMasterclass
{
    internal class program
    {
        static void Main(string[] args)
        {
            int[] min = {1,2,3,4,5,6,7,8,0};
            int minValue = MinValue(min);

            Console.Write("Min value is: {0}",minValue);

            Console.ReadKey();
        }

        public static int MinValue(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                    min = number;
            }
            return min;
        }
    }
}
