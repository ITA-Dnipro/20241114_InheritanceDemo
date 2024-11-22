using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241114_InheritanceDemo
{
    internal class UI
    {
        public static void Show(Picture p)
        {
            for (int i = 0; i < p.Size; i++)
            {
                Figure2D current = p[i];

                Console.WriteLine(current);
            }
        }
    }
}
