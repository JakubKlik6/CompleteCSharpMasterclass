using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Study
{
    internal class Sphere : Shape
    {
        public double radius { get; set; }
        public Sphere(double radius)
        {
            Name = "Sphere";
            this.radius = radius;
        }

        public override double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(radius, 3); 
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThe sphere has a radius of {radius}");
        }
    }
}
