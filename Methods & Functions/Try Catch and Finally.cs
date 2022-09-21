using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Eneter any number: ");
            string userInput = Console.ReadLine();

            try
            {
                int inputNumber = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please eneter the correct type! :)");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException exception, the value was empty");
            }
            finally     //Will be called, after try&catch
            {
                Console.WriteLine("This is called anyways");
            }


            Console.ReadKey();
        }
    }
}
