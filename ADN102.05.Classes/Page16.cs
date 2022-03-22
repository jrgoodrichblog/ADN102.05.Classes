using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//In this exercise you will add properties to a class

//Add Red, Green and Blue Properties that will throw an exception if the values are out of range.
//Add an Opacity Property that will set the value to 0 if the value is too low or
//will set the value to 255 if the value is too high

// use the backing storage fields provided

namespace Page16
{

    class Color
    {

        int _red;
        int _green;
        int _blue;
        int _opacity;

        // Red property

        private int check(int value, string color)
        {
            if (value < 0)
            {
                throw new Exception($"{color} value for a Color may not be less than 0, attempted: {value}");
            }
            else if (value > 255)
            {
                throw new Exception($"{color} value for a Color may not be greater than 255, attempted: {value}");
            }
            else
            {
                return value;
            }
        }

        // make this Red field into a Property

        public int Red;

        // make this Green field into a Property

        public int Green;

        // make this Blue field into a Property

        public int Blue;

        // make this Opacity field into a Property

        public int Opacity;

       
        



        // default ctor 
        public Color()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
            Opacity = 255;
        }

        // ctor accepting 1 integer

        public Color(int Red)
        {
            this.Red = Red;
            Green = Red;
            Blue = Red;
            Opacity = 255;
        }

        // ctor accepting 3 integers
        public Color(int Red, int Green, int Blue)
        {
            this.Red = Red;
            this.Green = Green;
            this.Blue = Blue;
            Opacity = 255;
        }

        // ctor accepting 4 integers
        public Color(int Red, int Green, int Blue, int Opacity)
        {
            this.Red = Red;
            this.Green = Green;
            this.Blue = Blue;
            this.Opacity = Opacity;
        }

    }
}

