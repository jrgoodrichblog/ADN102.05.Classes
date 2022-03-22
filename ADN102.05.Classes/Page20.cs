using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page20
{
    class Program
    {
        class Point                     // Point is now a class:  i.e. a reference type
        {
            public int w;
            private int x;
            protected int y;
            internal int z;
        }

        struct Line
        {
            static public Point P1;             // P1 is static
            public Point P2;

            static Line()                       // this ctor is used to create the payloads for static members (like P1)
            {
                P1 = new Point();
            }

        }
    }
}
