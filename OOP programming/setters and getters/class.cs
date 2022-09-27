using System;
using System.Collections.Generic;
using System.Text;

namespace completeMasterclass
{
    internal class Box
    {
        //member variable
        private int length = 0, width = 0, height = 0;

        public void SetLength(int length)
        {
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1} and width is {2]", length, width,height);
        }
    }
}
