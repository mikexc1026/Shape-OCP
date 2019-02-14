using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OCP
{
    class DrawingApp
    {
        public DrawingApp()
        {

        }

        public void drawAllShapes(List<IShape> shapes)
        {
            foreach (IShape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
