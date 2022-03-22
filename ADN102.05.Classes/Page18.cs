using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page18Part1
    
    {
    struct SPoint
    {
        public int w;
        private int x;
        private int y;  // protected not allowed in struct, use to private
        internal int z;
    }

    class CPoint
    {
        public int w;
        private int x;
        protected int y;
        internal int z;
    }

    class Program
    {
        static void Main()
        {
            SPoint p1;
            SPoint p2;


            CPoint cp1;
            CPoint cp2;
            CPoint cp3;

            cp1 = new CPoint();
            cp2 = new CPoint();
            cp3 = cp1;
        }
    }
}

namespace Page18StructEmbeddingStruct
{
    struct Point
    {
        public int w;
        private int x;
        private int y; // use private instead of protected in a struct
        internal int z;
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
            Line L= new Line();  // needed to initialize hiddent parts of the line structure
         
        }
    }
}

namespace Page18ClassEmbeddingStruct
{
    struct Point
    {
        public int w;
        private int x;
        private int y;
        internal int z;
    }
    class Line
    {
        public Point P1;
        public Point P2;
    }

    class Program
    {
        static void Main()
        {
            Line L = new Line();
        }
    }
}

namespace Page18StructEmbeddingClass
{
    class Point
    {
        public int w;
        private int x;
        private int y;
        internal int z;
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
            Line L = new Line();
            L.P1 = new Point();
            L.P2 = new Point();
        }
    }
}

namespace Page18ClassEmbeddingClass
{
    class Point
    {
        public int w;
        private int x;
        protected int y;
        internal int z;
    }
    class Line
    {
        public Point P1;
        public Point P2;
        public Line()
        {
            P1 = new Point();
            P2 = new Point();
        }
    }
    class Program
    {
        static void Main()
        {
            Line L = new Line();
            L.P1 = new Point();
            L.P2 = new Point();
        }
    }
}



