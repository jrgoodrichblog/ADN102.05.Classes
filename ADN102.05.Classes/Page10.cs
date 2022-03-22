using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page10
{
    class Color
    {
        public int Red;
        public int Green;
        public int Blue;
        public int Opacity;

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
            Red = Red;
            Green = Green;
            Blue = Blue;
            Opacity = 255;
        }

        // ctor accepting 4 integers
        public Color(int Red, int Green, int Blue, int Opacity )
        {
            Red = Red;
            Green = Green;
            Blue = Blue;
            Opacity = Opacity;
        }


    }
}
