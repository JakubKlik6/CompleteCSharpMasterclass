using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Study
{
    abstract class Shape
    {
        public string Name { get; set; }    

        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThe name is {Name}");
        }

        public abstract double Volume();

    }
}
