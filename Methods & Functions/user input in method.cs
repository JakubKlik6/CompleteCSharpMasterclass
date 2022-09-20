using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Sum();

            Console.ReadKey();
        }

        public static void Sum()
        {
            Console.Write("Please enter any integer: ");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Square of your number is: {0}", x * x);

        }
    }
}
