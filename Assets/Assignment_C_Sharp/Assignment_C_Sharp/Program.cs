using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area;
            radius = 3;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: " + radius +
            ", Area: " + area);
            Console.WriteLine("This is Assignmentn on C-Sharp");
            Console.WriteLine();
            Class1.Circle circle=new Class1.Circle(5);
            Console.ReadLine();
        }
    }
}
