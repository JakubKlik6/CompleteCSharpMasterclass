using System;

namespace InheritanceChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Graffi", 10, true);
            Console.WriteLine($"Dog name: {dog1.Name}, Dog Age: {dog1.Age}");
            dog1.Eat();
            dog1.Play();

            Console.ReadKey();
        }
    }
}
