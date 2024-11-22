using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20241114_InheritanceDemo
{
    // is a
    public class Circle : Figure2D
    {
        private int _r;

        public Circle(int x, int y, int r)
            : base(x, y)
        {
            _r = r;
        }

        public override void Resize(double delta)
        {
            _r = (int)(_r * delta);
        }

        public override string ToString()
        {
            return string.Format("Circle ({0}, {1}), r = {2}", _x, _y, _r);
        }
    }
}