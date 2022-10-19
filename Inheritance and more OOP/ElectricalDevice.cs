using System;
using System.Collections.Generic;
using System.Text;

namespace completeMasterclass
{
    internal class ElectricalDevice
    {
        //Parent class
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice(bool IsOn, string Brand)
        {
            this.IsOn = IsOn;
            this.Brand = Brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
