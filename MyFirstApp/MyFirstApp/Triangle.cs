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


            var edge1 = new Edge(Point1, Point2);
            var edge2 = new Edge(Point1, Point3);
            var edge3 = new Edge(Point2, Point3);

            this.Edge1 = edge1.Length;
            this.Edge2 = edge2.Length;
            this.Edge3 = edge3.Length;

            if (IsInvalid)
            {
                throw new ArgumentException();
            }

        }

        private bool IsInvalid
        {
            get
            {
                return (Edge1 + Edge2 <= Edge3 ||
                     Edge1 + Edge3 <= Edge2 ||
                     Edge2 + Edge3 <= Edge1);
            }

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
                return Math.Sqrt(p * (p - Edge1) * (p - Edge2) * (p - Edge3));
            }
        }
        public bool IsRight
        {    
            get
            {           
                var squareEdge1 = Edge1 * Edge1;
                var squareEdge2 = Edge2 * Edge2;
                var squareEdge3 = Edge3 * Edge3;

                return (squareEdge1 + squareEdge2 == squareEdge3 ||
                        squareEdge1 + squareEdge3 == squareEdge2 ||
                        squareEdge2 + squareEdge3 == squareEdge1); 
            }            
        }
        public bool IsIsosceles
        {
            get
            {
                return (Edge1 == Edge2 ||
                        Edge1 == Edge3 ||
                        Edge2 == Edge3);
            }
        }

        public static bool operator == (Triangle triangle1, Triangle triangle2)
        {
            var edge11 = triangle1.Edge1;
            var edge12 = triangle1.Edge2;
            var edge13 = triangle1.Edge3;

            var edge21 = triangle2.Edge1;
            var edge22 = triangle2.Edge2;
            var edge23 = triangle2.Edge3;

            return (edge11 == edge21 && edge12 == edge22 && edge13 == edge23 ||
                    edge11 == edge22 && edge12 == edge21 && edge13 == edge23 ||
                    edge11 == edge23 && edge12 == edge22 && edge13 == edge21 ||
                    edge11 == edge21 && edge12 == edge23 && edge13 == edge22);                  
        }

        public static bool operator != (Triangle triangle1, Triangle triangle2)
        {
            var edge11 = triangle1.Edge1;
            var edge12 = triangle1.Edge2;
            var edge13 = triangle1.Edge3;

            var edge21 = triangle2.Edge1;
            var edge22 = triangle2.Edge2;
            var edge23 = triangle2.Edge3;

            return (edge11 != edge21 || edge11 != edge22 || edge11 != edge23 ||
                    edge12 != edge21 || edge12 != edge22 || edge12 != edge23 ||
                    edge13 != edge21 || edge13 != edge22 || edge13 != edge23);    
        }
    }
}
