using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{        
    class Program
    {
        const int amountTriangle = 10;
        static void Main(string[] args)
        {
            var arrayOfTriangle = new Triangle [amountTriangle]; 
            
            int i = 0;
            while (i < amountTriangle)
            {   
                bool flag = false;
                while (!flag)
                {
                    Random rand = new Random();
                    var point1 = new Point(rand.Next(0,10), rand.Next(0,10));
                    var point2 = new Point(rand.Next(0,10), rand.Next(0,10));
                    var point3 = new Point(rand.Next(0,10), rand.Next(0,10));

                    arrayOfTriangle[i] = new Triangle(point1, point2, point3);
                    //exception in constructor
                    if (arrayOfTriangle[i].CheckForCorrect()) flag = true;
                }
                i++;
            }

            int countRightTriangle = 0, countIsoscelesTriangle = 0;
            double perimeterOfRight = 0.0, areaOfIsosceles = 0.0;

            for (i = 0; i < amountTriangle; i++)
            {
                Console.WriteLine(arrayOfTriangle[i].Perimeter);
                if(arrayOfTriangle[i].Squareness)
                {
                    countRightTriangle ++;
                    perimeterOfRight += arrayOfTriangle[i].Perimeter;
                }

                if(arrayOfTriangle[i].Isosceles)
                {
                    countIsoscelesTriangle ++;
                    areaOfIsosceles += arrayOfTriangle[i].Area;
                }

            }
            if (countRightTriangle != 0)
                Console.WriteLine("Average perimeter of right triangles = " + perimeterOfRight / countRightTriangle);
            else Console.WriteLine("No right triangles");
            if (countIsoscelesTriangle != 0)
                Console.WriteLine("Average area of isosceles triangles = " + areaOfIsosceles / countIsoscelesTriangle);
            else Console.WriteLine("No isosceles triangles");
        }
    }
}
