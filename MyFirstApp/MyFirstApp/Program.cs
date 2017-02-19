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
        static void Main()
        {

            int amountTriangle = 0;
            Console.WriteLine("Input number of triangles");

            try
            {
                amountTriangle = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("It's not a number\n");
                Main();
            }

            var arrayOfTriangle = new ArrayTriangle(amountTriangle);



            //var arrayTriangle = new Triangle [amountTriangle];
            /*Triangle[] arrayTriangle;



            Random rand1 = new Random(1);
            Random rand2 = new Random(2);
            int i = 0;
            while (i < amountTriangle)
            {
                bool flag = false;
                while (!flag)
                {

                    var point1 = new Point(rand1.Next(0, 11), rand2.Next(0, 11));

                    var point2 = new Point(rand1.Next(0, 11), rand2.Next(0, 11));

                    var point3 = new Point(rand1.Next(0, 11), rand2.Next(0, 11));

                    try
                    {
                        arrayTriangle[i] = new Triangle(point1, point2, point3);
                        flag = true;
                    }
                    catch (Exception)
                    {

                    }
                }
                i++;
            }

            int countRight = 0, countIsosceles = 0;
            double perimeterOfRight = 0.0, areaOfIsosceles = 0.0;

            for (i = 0; i < amountTriangle; i++)
            {
                Console.WriteLine(arrayTriangle[i].Area);
                if (arrayTriangle[i].IsSquareness)
                {
                    countRight++;
                    perimeterOfRight += arrayTriangle[i].Perimeter;
                }

                if (arrayTriangle[i].IsIsosceles)
                {
                    countIsosceles++;
                    areaOfIsosceles += arrayTriangle[i].Area;
                }

            }

            if (countRight != 0)
                Console.WriteLine("Average perimeter of right triangles = " + perimeterOfRight / countRight);
            else Console.WriteLine("No right triangles");

            if (countIsosceles != 0)
                Console.WriteLine("Average area of isosceles triangles = " + areaOfIsosceles / countIsosceles);
            else Console.WriteLine("No isosceles triangles");*/
        }
    }
}
