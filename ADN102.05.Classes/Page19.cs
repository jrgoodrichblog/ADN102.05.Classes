using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page19Ordinary
{
    struct Point
    {
        public int w;
        public int x;
        public int y;
        public int z;
    }

    class Program
    {
        static void Main()
        {
            Point p1;
            Point p2;
        }
    }
}

namespace Page19Static
{
    struct Point
    {
        static public int w;     // this is the change
        public int x;
        public int y;
        public int z;
    }

    class Program
    {
        static void Main()
        {
            Point p1;
            Point p2;
        }
    }
}

namespace Page19StructEmbeddedStructOrdinary
{
    struct Point
    {
        public int w;
        public int x;
        public int y;
        public int z;
    }
    struct Line
    {
        public Point P1;
        public Point P2;
    }

    class Program
    {
        static void Main()
        {
            Line L1;
            Line L2;
        }
    }
}

namespace Page19StructEmbeddedStructStatic
{
    struct Point
    {
        public int w;
        public int x;
        public int y;
        public int z;
    }
    struct Line
    {
       static  public Point P1;
        public Point P2;
    }

    class Program
    {
        static void Main()
        {
            Line L1;
            Line L2;
        }
    }
}

namespace Page19StructWithEmbeddedClassOrdinary
{
    class Point                     // Point is now a class:  i.e. a reference type
    {
        public int w;
        private int x;
        protected int y;
        internal int z;
    }
    struct Line                     // Line is still a struct: i.e a value type
    {
        public Point P1;
        public Point P2;

    }

    class Program
    {
        static void Main()
        {
            Line L1;
            L1.P1 = new Point();        // initialize the payload for P1 in the first line
            L1.P2 = new Point();        // initialize the payload for P2 in the first line
            Line L2;
            L2.P1 = new Point();        // initialize the payload for P1 in the second line
            L2.P2 = new Point();        // initialize the payload for p2 in the second line 
        }
    }
}

namespace Page19StructWithEmbeddedClassStatic
{
    class Point                     // Point is now a class:  i.e. a reference type
    {
        public int w;
        private int x;
        protected int y;
        internal int z;
    }
    struct Line                     // Line is still a struct: i.e a value type
    {
        static public Point P1;
        public Point P2;

    }

    class Program
    {
        static void Main()
        {
          
            Line.P1 = new Point();        // initialize the static variable P1 with payload
                                          //  this variable is shared between all instances


            Line L1;
            L1.P2 = new Point();        // initialize the payload for P2 in the first line


            Line L2;
            L2.P2 = new Point();        // initialize the payload for p2 in the second line 
        }
    }
}



