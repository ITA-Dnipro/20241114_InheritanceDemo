using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20241114_InheritanceDemo
{
    public class Point2D : Figure2D
    {
        public Point2D(int x, int y)
            : base(x, y)
        {
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", _x, _y);
        }

        public override void Resize(double delta)
        {
        }
    }
}