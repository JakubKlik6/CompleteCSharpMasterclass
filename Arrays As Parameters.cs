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
            int[] studentsGrades = { 1, 2, 3, 4, 5, 6 };
            double averageGrades = gradesAverage(studentsGrades);

            Console.Write("Grades average is {0}", averageGrades);
            Console.ReadKey();
        }

        public static double gradesAverage(int[] array)
        {
            int size = array.Length;
            double averege, sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }
            averege = sum / size;
            return averege;
        }
    }
}
