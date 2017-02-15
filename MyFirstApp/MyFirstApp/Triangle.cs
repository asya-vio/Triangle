using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Triangle
    {
        public readonly Point Point1;
        public readonly Point Point2;
        public readonly Point Point3;

        public readonly double Edge1;
        public readonly double Edge2;
        public readonly double Edge3;

        public Triangle(Point Point1, Point Point2, Point Point3)
        {
            this.Point1 = Point1;
            this.Point2 = Point2;
            this.Point3 = Point3;

            //check

            var Edge1 = new Edge(Point1, Point2);
            var Edge2 = new Edge(Point1, Point3);
            var Edge3 = new Edge(Point2, Point3);

            this.Edge1 = Edge1.Length;
            this.Edge2 = Edge2.Length;
            this.Edge3 = Edge3.Length;

        }

        public bool CheckForCorrect()
        {
            if (Edge1 + Edge2 <= Edge3 ||
                Edge1 + Edge3 <= Edge2 ||
                Edge2 + Edge3 <= Edge1)
                return false;
            else return true;
        }

        public double Perimeter
        {
            get
            {
                return Edge1 + Edge2 + Edge3;
            }
        }

        public double Area
        {
            get
            {
                var p = Perimeter / 2;

                return Math.Sqrt(p * (p - Edge1) * 
                                (p - Edge2) * (p - Edge3));
            }
        }

        public bool CheckTriangleForSquareness()//get
        {
            var squareOfFirstEdge = Edge1 * Edge1;
            var squareOfSecondEdge = Edge2 * Edge2;
            var squareOfThirdEdge = Edge3 * Edge3;

            return(squareOfFirstEdge + squareOfSecondEdge == squareOfThirdEdge ||
                squareOfFirstEdge + squareOfThirdEdge == squareOfSecondEdge ||
                squareOfSecondEdge + squareOfThirdEdge == squareOfFirstEdge);
                
        }

        public bool CheckTriangleForIsosceles()//get
        {
            if (Edge1 == Edge2 ||
                Edge1 == Edge3 ||
                Edge2 == Edge3)
                return true;
            else return false;
        }


    }
}
