using System;

namespace completeMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human Jakub = new Human();
            Jakub.firstName = "Jakub";
            Jakub.lastName = "Klik";
            Jakub.InroduceMySelf();

            Human Jasiu = new Human();
            Jasiu.firstName = "Jasiu";
            Jasiu.lastName = "Domeracki";
            Jasiu.InroduceMySelf();

            Console.Read();
        }
    }
}
