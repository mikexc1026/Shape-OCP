using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Naive
{
    class Circle : Shape
    {
        private double radius;
        //private Point center;

        public Circle(double r/*, Point c*/) : base(ShapeType.Circle)
        {
            radius = r;
            //center = c;
        }

        public void drawCircle()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
