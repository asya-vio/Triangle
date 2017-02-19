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
        static int Main()
        {

            int amountTriangle = 0;
            Console.WriteLine("Input positive number of triangles");

            try
            {            
                amountTriangle = int.Parse(Console.ReadLine());
                if (amountTriangle < 0) throw new ArgumentException();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("It's not a positive number\n");
                return Main();
            }
            catch (FormatException)
            {
                Console.WriteLine("It's not a number\n");
                return Main();
            }

            var arrayOfTriangle = new ArrayTriangle(amountTriangle);

            if (arrayOfTriangle.AreaIsosceles > 0)
                Console.WriteLine("Average area of isosceles triangles = {0}", arrayOfTriangle.AreaIsosceles / arrayOfTriangle.AmountOfIsosceles);
            else Console.WriteLine("No isosceles triangles");

            if (arrayOfTriangle.PerimeterRight > 0)
                Console.WriteLine("Average perimeter of right triangles = {0}",arrayOfTriangle.PerimeterRight / arrayOfTriangle.AmountOfRight);            
            else Console.WriteLine("No right triangles");

            return 0;
        }
    }
}
