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
            ParamsMethod("Jacek", "Jakub","Maciek","Jasiu");
        }

        static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }
    }
}
