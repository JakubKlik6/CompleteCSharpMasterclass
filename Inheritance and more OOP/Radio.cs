using completeMasterclass;
using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class Radio : ElectricalDevice
    {
        //child class
        public Radio (bool IsOn, string Brand) : base(IsOn, Brand)
        {

        }

        public void IsRadioOn()
        {
            if (IsOn)
            {
                Console.WriteLine("Radio is on");
            }

            else
            {
                Console.WriteLine("Radio is off");
            }
        }
    }
}
