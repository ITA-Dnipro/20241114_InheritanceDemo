using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20241114_InheritanceDemo
{
    public class C : B
    {
        public void F()
        {
            Console.WriteLine("C.F()");
        }

        public override void FVirt()
        {
            Console.WriteLine("C.FVirt()");
        }
    }
}