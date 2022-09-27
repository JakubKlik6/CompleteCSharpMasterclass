using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace completeMasterclass
{
    internal class Box
    {
        //member variable
        private int length, height;

        //Length
        public void SetLength(int length)
        {
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }

        //height
        public int Height
        {
            get 
            { 
                return height; 
            }
            set
            {
                this.height = value;    
            }
        }

        //width
        public int width { get; set; }

        //volume
        public int volume
        {
            get
            {
                return Height * width * this.length;
            }
        }

        //Constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            Height = height;
            this.width = width;
        }


        //Display info
        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {this.length}, height is {this.width} and width is {Height}. Volume equals {volume}");
        }
    }
}
