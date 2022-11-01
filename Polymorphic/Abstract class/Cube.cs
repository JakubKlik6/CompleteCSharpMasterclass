using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Study
{
    internal class Cube : Shape
    {
        public double lenght { get; set; }
        public Cube(double lenght)
        {
            Name = "Cube";
            this.lenght = lenght;
        }

        public override double Volume()
        {
            return Math.Pow(lenght, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThe cube has a lengh of {lenght}");
        }
    }
}
