using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLabChallenge1
{
    internal class circle
    {
        protected double Radius;
        protected string Colour;
        public circle()
        { }

        public circle(double radius)
        {
            this.Radius = radius;
        }
        public circle(double radius, string colour)
        {
            Radius = radius;
            Colour = colour;
        }
        public void Setradius(double radius)
        {
            this.Radius = radius;
        }
        public void Setcolour(string colour)
        {
            this.Colour = colour;
        }
        public double getradius()
        {
            return this.Radius;
        }
        public string getColour()
        {
            return this.Colour;
        }
        public double getArea()
        {
            double area = 0;
            double r = Radius;
            area = r * r;
            return area;
        }
        public string tostring()
        {
            return $"Circle[Radius={Radius},Colour={Colour}]";





        }
    }
}
