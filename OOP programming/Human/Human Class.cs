using System;
using System.Collections.Generic;
using System.Text;

namespace completeMasterclass
{
    internal class Human
    {
        public string firstName, lastName;

        public void InroduceMySelf()
        {
            Console.WriteLine("Hi, my name is {0}",firstName + " " + lastName);
        }
    }
}
