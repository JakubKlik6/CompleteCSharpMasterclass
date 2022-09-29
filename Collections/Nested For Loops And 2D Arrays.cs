using MembersC;
using System;
using System.ComponentModel;

namespace completeMasterclass
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        static void Main(string[] args)
        {
            foreach (int matrixElement in matrix)
            {
                Console.Write(matrixElement + " ");
            }

            //new line
            Console.WriteLine("");

            //nested for loop

            //outer loop
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner loop
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
        }
    }
}
