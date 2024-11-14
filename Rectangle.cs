using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20241114_InheritanceDemo
{
    public class Rectangle : Figure2D
    {
        private int _x2; 
        private int _y2;

        public Rectangle(int x, int y, int x2, int y2)
           : base(x, y)
        {
            _x2 = x2;
            _y2 = y2;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}) - ({2}, {3})", _x, _y, _x2, _y2);
        }

        public override void Move(int dx, int dy)
        {
            base.Move(dx, dy);

            //_x += dx;
            //_y += dy;

            _x2 += dx;
            _y2 += dy;
        }

        public override void Resize(double delta)
        {
            // ToDo: !!!
        }

    }
}