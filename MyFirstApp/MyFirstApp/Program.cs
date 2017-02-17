using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyFirstApp
{        
    class Program
    {
        const int amountTriangle = 10;
        static void Main(string[] args)
        {
            var arrayOfTriangle = new Triangle [amountTriangle];
            Random rand1 = new Random(1);
            Random rand2 = new Random(2);
            int i = 0;
            while (i < amountTriangle)
            {   
                bool flag = false;
                while (!flag)
                {

                    var point1 = new Point(rand1.Next(0,11), rand2.Next(0,11));                    
                  
                    var point2 = new Point(rand1.Next(0,11), rand2.Next(0,11));
                    
                    var point3 = new Point(rand1.Next(0,11), rand2.Next(0,11));

                    try
                    {
                        arrayOfTriangle[i] = new Triangle(point1, point2, point3);
                        flag = true;
                    }
                    catch(Exception)
                    {

                    }
                }
                i++;
            }

            int countRight = 0, countIsosceles = 0;
            double perimeterOfRight = 0.0, areaOfIsosceles = 0.0;

            for (i = 0; i < amountTriangle; i++)
            {
                Console.WriteLine(arrayOfTriangle[i].Area);
                if(arrayOfTriangle[i].Squareness)
                {
                    countRight ++;
                    perimeterOfRight += arrayOfTriangle[i].Perimeter;
                }

                if(arrayOfTriangle[i].Isosceles)
                {
                    countIsosceles ++;
                    areaOfIsosceles += arrayOfTriangle[i].Area;
                }

            }

            if (countRight != 0)
                Console.WriteLine("Average perimeter of right triangles = " + perimeterOfRight / countRight);
            else Console.WriteLine("No right triangles");

            if (countIsosceles != 0)
                Console.WriteLine("Average area of isosceles triangles = " + areaOfIsosceles / countIsosceles);
            else Console.WriteLine("No isosceles triangles");
        }
    }
}
