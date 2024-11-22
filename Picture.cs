using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20241114_InheritanceDemo
{
    public class Picture
    {
        private List<Figure2D> _figures;    // has / part of

        public Picture(int capacity)
        {
            _figures = new List<Figure2D>(capacity);
        }

        public void Add(Figure2D f)
        { 
            _figures.Add(f);
        }

        public void Move(int dx, int dy)
        {
            foreach (Figure2D f in _figures)
            { 
                f.Move(dx, dy); 
            }
        }

        public void Remove(int pos) 
        { 
            _figures.RemoveAt(pos);
        }

        public int Size
        {
            get 
            { 
                return _figures.Count; 
            }
        }

        public Figure2D this[int index]
        {
            get 
            {
                if (index < 0 || index >= _figures.Count)
                {
                    // validation
                    //throw ....
                }

                return _figures[index]; 
            }
            set 
            {
                if (index < 0 || index >= _figures.Count)
                {
                    // validation
                    //throw ....
                }

                _figures[index] = value;
            }
        }
    }
}