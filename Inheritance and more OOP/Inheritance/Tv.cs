using completeMasterclass;
using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class Tv : ElectricalDevice
    {
        //child class
        public Tv(bool IsOn, string Brand): base(IsOn, Brand)
        {

        }

        public void IsTvOn()
        {
            if (IsOn)
            {
                Console.WriteLine("Tv is on");
            }
            else
            {
                Console.WriteLine("Tv is off");
            }
        }
    }
}
