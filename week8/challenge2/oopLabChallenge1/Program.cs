using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLabChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            cylinder c = new cylinder(30,10,"Red");
            Console.WriteLine(c.getradius());
            Console.WriteLine(c.getColour());
            Console.WriteLine(c.getArea());
            Console.WriteLine(c.getVolume());
            c.Setcolour("Blue");
            c.setHeight(20);
            c.Setradius(30);
            Console.WriteLine(c.getradius());
            Console.WriteLine(c.getColour());
            Console.WriteLine(c.getArea());
            Console.WriteLine(c.getVolume());
            Console.WriteLine(Console.ReadLine());

        }
    }
}
