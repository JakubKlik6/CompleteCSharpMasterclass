using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string value: ");
            string input = Console.ReadLine();

            Console.Write("Enter the character to search: ");
            char dataToSearch = Console.ReadLine()[0];

            int searchIndex = input.IndexOf(dataToSearch);

            Console.WriteLine("Index character {0} in string is {1}", dataToSearch, searchIndex);

            Console.Write("Enter you name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter you surname: ");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            

            Console.ReadKey(true);
        }

    }
}   
