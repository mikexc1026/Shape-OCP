﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OCP
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
