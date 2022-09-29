using MembersC;
using System;
using System.ComponentModel;

namespace completeMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;

            Console.Write("Enter any value: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("\nChoose the data type of value: ");
            Console.WriteLine("Press 1 fo String");
            Console.WriteLine("Press 2 fo integer");
            Console.WriteLine("Press 3 fo Boolean");
            string userChoice = Console.ReadLine();

            int number, userInputNumber;

            if(int.TryParse(userChoice, out number))
            {
                switch (number)
                {
                    case 1:
                        {
                            foreach (char k in userInput)
                            {
                                if (!char.IsLetter(k))
                                    Console.WriteLine("This is not string");
                                break;
                            }
                            Console.WriteLine("This is string");
                        }
                        break;
                    case 2:
                        {
                            if (int.TryParse(userInput, out userInputNumber))
                                Console.WriteLine("This is valid integer");
                            else
                                Console.WriteLine("This is not valid integer");
                        }
                        break;
                    case 3:
                        {
                            bool isBoolean = false;
                            valid = bool.TryParse(userInput, out isBoolean);
                            Console.WriteLine("This is Boolean");
                        }
                        break;
                    default:
                        Console.WriteLine("Eneter valid value!");
                        break;
                }
            }

            Console.Read();
        }
    }
}
