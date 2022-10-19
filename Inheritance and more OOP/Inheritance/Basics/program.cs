using inheritance;
using System;

namespace completeMasterclass
{
    internal class program
    {
        static void Main(string[] args)
        {
            Radio speaker = new Radio(true, "Marshall");
            speaker.SwitchOff();
            speaker.IsRadioOn();

            Tv miTV = new Tv(true, "Xiaomi");

            
        }
    }
}
