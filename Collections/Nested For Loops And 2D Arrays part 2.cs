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
            //nested for loop
            //outer loop
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner loop
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    //print diagonal numbers (1,5,9)
                    if (i == j)
                        Console.Write(matrix[i, j] + " ");
                    else
                        continue;
                }
            }

            //new line
            Console.WriteLine(" ");

            //diagonal numbers with one for loop (1,5,9)
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i,i] + " ");
            }

            //new line
            Console.WriteLine(" ");


            //diagonal numbers (7,5,3), only if row = column
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--) 
            {
                Console.Write(matrix[i,j] + " ");
            }
        }
    }
}
