using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Point
    {
        public readonly int x,y;

        public  Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        ~Point()
        {

        }
    }
}
