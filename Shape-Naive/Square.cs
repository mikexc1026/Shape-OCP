using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Naive
{
    class Square:Shape
    {
        private double side;
        //private Point topLeft;

        public Square(double s/*, Point tl*/): base(ShapeType.Square)
        {
            side = s;
            //center = c;
        }

        public void drawSquare()
        {
            Console.WriteLine("Drawing a square");
        }
    }
}
