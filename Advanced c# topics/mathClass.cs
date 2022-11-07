using System;

namespace Csharp_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ceiling
            Console.WriteLine("Ceiling 15.2: " + Math.Ceiling(15.2));
            //Floor
            Console.WriteLine("Floor 15.2: " + Math.Floor(15.3));
            //Getting lower number
            int x = 9, y = 11;
            Console.WriteLine("Lower num: " + Math.Min(x,y));
            //Power
            Console.WriteLine("Two to 3rd power: " + Math.Pow(2,3));

        }
        #region
        //Task
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static void Run(string line)
        {
            try
            {
                int.TryParse(line, out int number);
                if ((number > 0) && (number < 180))
                {
                    Console.WriteLine("Cos = " + Math.Cos(ConvertToRadians(number)));
                    Console.WriteLine("Sin = " + Math.Sin(ConvertToRadians(number)));
                    Console.WriteLine("Tg = " + Math.Tan(ConvertToRadians(number)));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Check the input!");
            } 
        }
        #endregion
    }
}
