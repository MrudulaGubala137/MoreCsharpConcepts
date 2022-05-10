using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp
{
    internal class Class1
    {
       
        public class Circle
        {
            int radius; // Variables
            float area;

            //Constructor
            public Circle(int radius)
            {
                
                this.radius = radius;
                area = (float)(Math.PI * Math.Pow(radius, 2));
                Console.WriteLine(area);
               

            }
            // Getting Parameters
            public int Radius
            {
                get
                {

                    return radius;
                }
            }

            // Getting the area of the circle

            public float Area
            {
                get { return area; }
            }
        }
    }
}

