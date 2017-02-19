using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class ArrayTriangle
    {
        public readonly int numberTriangle;
        public List<Triangle> ArrTriangle;
        //public Triangle[] ArrTriiangle = new Triangle[numberTriangle]; 
        public ArrayTriangle(int number)
        {
            numberTriangle = number;

            Random rand1 = new Random(1);
            Random rand2 = new Random(2);
            int i = 0;
            while (i < numberTriangle)
            {
                bool flag = false;
                while (!flag)
                {

                    var point1 = new Point(rand1.Next(0, 11), rand2.Next(0, 11));
                    var point2 = new Point(rand1.Next(0, 11), rand2.Next(0, 11));
                    var point3 = new Point(rand1.Next(0, 11), rand2.Next(0, 11));

                    try
                    {
                        ArrTriangle[i] = new Triangle(point1, point2, point3);
                        flag = true;
                    }
                    catch (ArgumentException)
                    {

                    }
                }
                i++;
            }
        }

        public int AmountOfRight
        {
            get
            {
                int amountRight = 0;
                for (int i = 0; i < numberTriangle; i++)
                    amountRight++;

                return amountRight;
            }
        }

        public int AmountOfIsosceles
        {
            get
            {
                int amountIsosceles = 0;
                for (int i = 0; i < numberTriangle; i++)
                    amountIsosceles++;
                return amountIsosceles;
            }
        }

        public double PerimeterRight
        {
            get
            {
                double perimeter = 0.0;
                for (int i = 0; i < numberTriangle; i++)
                    if (ArrTriangle[i].IsRight)
                        perimeter += ArrTriangle[i].Perimeter;
                return perimeter;
            }
        }

        public double AreaIsosceles
        {
            get
            {
                double area = 0.0;
                for (int i = 0; i < numberTriangle; i++)
                    if (ArrTriangle[i].IsIsosceles)
                        area += ArrTriangle[i].Area;
                return area;
            }
        }
    }
}
