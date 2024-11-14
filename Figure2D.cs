using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20241114_InheritanceDemo
{
    public abstract class Figure2D
    {
        #region Private data

        protected int _x;
        protected int _y;

        #endregion

        public Figure2D(int x, int y)
        {
            _x = x;
            _y = y;
        }

        #region getters/setters

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }

        public void SetX(int x)
        {
            // valudation
            if (x < 0)
            {
                return;    // throw
            }

            _x = x;
        }

        public void SetY(int y)
        {
            // valudation
            if (y < 0)
            {
                return;    // throw
            }

            _y = y;
        }

        #endregion


        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                // valudation
                if (value < 0)
                {
                    return;    // throw
                }

                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                // valudation
                if (value < 0)
                {
                    return;    // throw
                }

                _y = value;
            }
        }

        public virtual void Move(int dx, int dy)
        {
            _x += dx;
            _y += dy;
        }

        //public virtual void Resize(double delta)
        //{ 
        //}

        public abstract void Resize(double delta);
    }
}