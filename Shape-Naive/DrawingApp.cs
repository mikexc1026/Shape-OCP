using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Naive
{
    class DrawingApp
    {
        public DrawingApp()
        {

        }

        public void drawAllShapes(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.getType() == ShapeType.Circle)
                {
                    ((Circle)shape).drawCircle();
                }
                else if (shape.getType() == ShapeType.Square)
                {
                    ((Square)shape).drawSquare();
                }
            }
        }
    }
}
