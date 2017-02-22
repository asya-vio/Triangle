using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Point
    {
        public readonly int X,Y;

        public  Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static bool operator == (Point point1, Point point2)
        {
            return point1.X == point2.X && point1.Y == point2.Y;
        }

        public static bool operator != (Point point1, Point point2)
        {
            return point1.X != point2.X || point1.Y != point2.Y;
        }
       
    }
}
