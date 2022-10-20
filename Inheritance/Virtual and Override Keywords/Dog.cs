using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    internal class Dog : Animal
    {
        //bool property to check if dog is happy
        public bool IsHappy { get; set; }

        //simple constructor where we pass name and age from our base constructor
        public Dog(string Name, int Age, bool IsHungry) : base(Name, Age, IsHungry)
        {
            //all dogs are happy :)
            this.IsHappy = true;
        }

        //simple override of the virtual Eat method 
        public override void Eat()
        {
            //to call eat method from our base class we used "base" keyword 
            base.Eat();
        }

        //simple override of the virtual MakeSound method 
        public override void MakeSound()
        {
            Console.WriteLine("Wuuuuf");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine("Dog is not happy");
            }
        }
    }
}
