using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Naive
{
    class Shape
    {
        private ShapeType type;

        public Shape(ShapeType t)
        {
            type = t;
        }

        public ShapeType getType()
        {
            return type;
        }
    }
}
