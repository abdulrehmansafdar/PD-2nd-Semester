using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLabChallenge1
{
    internal class cylinder:circle
    {
        private double height;

        public cylinder()
        {

        }
        public cylinder(double height)
        {
            this.height = height;
        }
        public cylinder(double height,double radius)
        {
            this.height=height;
            this.Radius=radius;
        }
        public cylinder(double height, double radius,string Colour)
        { this.height=height;
            this.Colour = Colour;
            this.Radius=radius;

        }
        public void setHeight(double height)
        { this.height = height; }
        
        public double getHeight()
            { return this.height; }

        public double getVolume()
        {
            double volume = 0;
           
            volume=3.14*(Radius*Radius)*height;
            return volume;
        }
    }
}
