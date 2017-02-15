using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Edge
    {
      private Point point1;
      private Point point2;

       public Edge(Point point1, Point point2)
       {
           this.point1 = point1;
           this.point2 = point2;
       }
       public double Length
       {
           get
           {
               return Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) +
                               (point1.Y - point2.Y) * (point1.Y - point2.Y));
           }
       }

    }
}
