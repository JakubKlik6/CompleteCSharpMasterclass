using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string nameInput = "";

            while(nameInput.Equals(""))
            {
                Console.Write("Press enter if you want to increase amount of ppl, or anything else to finish counting.");
                nameInput = Console.ReadLine();

                counter += 1;
            }
            Console.WriteLine("There is {0} persons.",counter);

            Console.Read();
        }
    }
}
