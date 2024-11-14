using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20241114_InheritanceDemo
{
    public class A
    {
        public void F()
        {
            Console.WriteLine("A.F()");
        }

        public virtual void FVirt()
        {
            Console.WriteLine("A.FVirt()");
        }

    }
}