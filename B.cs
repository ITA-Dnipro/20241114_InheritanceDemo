using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20241114_InheritanceDemo
{
    public class B : A
    {
        public void F()
        {
            Console.WriteLine("B.F()");
        }

        public override void FVirt()
        {
            Console.WriteLine("B.FVirt()");
        }
    }
}