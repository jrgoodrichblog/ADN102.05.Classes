using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page21
{

    class StaticError
    {
        int i;                              // this is an instance field called i.
        public static void Main()           // this is a static method 
        {
  //          Console.WriteLine(i);           // the static method Main does not have access to the instance variable i
        }

    }

    public static class MyMath
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
    }

    class Point
    {
        double _x;
        double _y;
        public double X { get { return _x; } set { _x = value; } }
        public double Y { get { return _y; } set { _y = value; } }
    }

    class Program
    {
        Point P = new Point();
       // p.Hypotenuse();
    }

    //static class PointExtender
    //{
    //    public static double Hypotenuse(this Point p)
    //    {
    //        return Math.Sqrt(p.X * p.X + p.Y * p.Y);
    //    }
    //}


}
