using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            string friend1 = "Jasiu", friend2 = "Maciek", friend3 = "Mateusz";

            GreetFriend(friend1);

            GreetFriend(friend2);

            GreetFriend(friend3);

            Console.Read();
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hi {0}, my friend!",name);
        }
    }
}
