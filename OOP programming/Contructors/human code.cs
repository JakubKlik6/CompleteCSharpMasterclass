using System;

namespace completeMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human Jakub = new Human("Jakub Klik","Brown",23);
            Jakub.InroduceMySelf();

            Human Jasiu = new Human("Jasiu Domeracki", "Green",23);
            Jasiu.InroduceMySelf();

            Console.Read();
        }
    }
}
