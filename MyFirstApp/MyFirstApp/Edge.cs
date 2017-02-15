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
               return Math.Sqrt((point1.x - point2.x) * (point1.x - point2.x) +
                               (point1.y - point2.y) * (point1.y - point2.y));
           }
       }

    }
}
