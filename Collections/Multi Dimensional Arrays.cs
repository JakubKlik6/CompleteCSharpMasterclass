using MembersC;
using System;
using System.ComponentModel;

namespace completeMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D array
            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            Console.WriteLine(array2D[2,0]);

            //3-Dimensions are more complex, but the Conzept is the same
            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001", "002" },
                    {"010", "011", "012" },
                    {"020", "021", "022" }
                },
                {
                    {"100", "101", "102" },
                    {"110", "111", "112" },
                    {"120", "121", "122" }
                },

            };

            //We access the Value "201"
            Console.WriteLine(array3D[1, 0, 1]);

            //Rank of arrays
            Console.WriteLine($"Rank of array is {array3D.Rank}");

            Console.Read();
        }
    }
}
