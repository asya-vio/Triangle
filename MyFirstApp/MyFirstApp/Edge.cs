using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Edge
    {
      public Point Point1;
      public Point Point2;

       public Edge(Point Point1, Point Point2)
       {
           this.Point1 = Point1;
           this.Point2 = Point2;
       }
       public double Length
       {
           get
           {
               return Math.Sqrt((Point1.X - Point2.X) * (Point1.X - Point2.X) +
                               (Point1.Y - Point2.Y) * (Point1.Y - Point2.Y));
           }
       }


    }
}
