using System;
using System.Collections.Generic;
using System.Text;

namespace completeMasterclass
{
    internal class Human
    {
        private string fullName, eyeColor;
        private int age;

        public Human(string fullName, string eyeColor, int age)
        {
            this.fullName = fullName;
            this.eyeColor = eyeColor;
            this.age = age;
        }   

        public void InroduceMySelf()
        {
            Console.WriteLine($"Hi, my name is {fullName}, my eyes are {eyeColor}, and I'm {age} years old");
        }
    }
}
