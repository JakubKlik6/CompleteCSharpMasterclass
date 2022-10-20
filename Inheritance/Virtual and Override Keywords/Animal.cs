using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    internal class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string Name, int Age, bool IsHungry)
        {
            this.Name = Name;
            this.Age = Age;
            this.IsHungry = true;
        }

        //an empty virtual Method MakeSound for other class to override
        public virtual void MakeSound()
        {

        }

        //an empty virtual Method Eat for other class to override
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} eat");
                IsHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        //an empty virtual Method Play for other class to override
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing!");
        }
    }
}
