using System;

namespace completeMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.SetLength(5);

            Console.WriteLine($"Box length is {box.GetLength()}");
        }
    }
}
