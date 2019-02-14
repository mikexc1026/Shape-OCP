using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Naive
{
    enum ShapeType { Circle, Square };

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> allShapes;
            DrawingApp drawingApp = new DrawingApp();

            allShapes = new List<Shape>();
            allShapes.Add(new Circle(2.3));
            allShapes.Add(new Square(2));

            drawingApp.drawAllShapes(allShapes);

            Console.ReadLine();
        }
    }
}
