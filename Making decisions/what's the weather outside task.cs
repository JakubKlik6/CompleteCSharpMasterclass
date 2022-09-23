using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please eneter temperature: ");
            string temperature = Console.ReadLine();

            int numTemp = int.Parse(temperature);
            string weatherOutside;

            if (int.TryParse(temperature, out numTemp))
            {
                weatherOutside = numTemp <= 15 ? "it is too cold here" : (numTemp >= 16 ? "it is ok" : "it is hot here");
                Console.WriteLine(weatherOutside);
            }
            else
                Console.WriteLine("Not a valid Temperature");

            Console.ReadKey();
        }
    }
}
