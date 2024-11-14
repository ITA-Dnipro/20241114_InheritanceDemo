namespace _20241114_InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoDemo1();

            //DoDemo2();
        }

        private static void DoDemo2()
        {
            A objA = new A();
            B objB = new B();
            C objC = new C();

            objA.F();
            objB.F();
            objC.F();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            RunF(objA);
            RunF(objB);    // upcast
            RunF(objC);    // upcast

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            objA.FVirt();
            objB.FVirt();
            objC.FVirt();

            Console.ForegroundColor = ConsoleColor.Red;

            RunFVirt(objA);
            RunFVirt(objB);    // upcast
            RunFVirt(objC);    // upcast
        }

        public static void RunFVirt(A instance)
        {
            instance.FVirt();
        }
        

        public static void RunF(A instance)
        {
            C instanceC = instance as C;    // RTTI

            if (instanceC != null) 
            {
                instanceC.F();
                return;
            }

            if (instance is B)    // RTTI
            {
                ((B)instance).F();    // downcast
            }
            else
            {
                instance.F();
            }

            // :(
            //if (instance is B)    // RTTI
            //{
            //    (instance as B).F();    // RTTI + // downcast
            //}


            Console.WriteLine();
        }

        private static void DoDemo1()
        {
            Circle c1 = new Circle(4, 3, 2);

            //c1._x = 1;

            Rectangle r1 = new Rectangle(3, 4, 10, 7);

            Console.WriteLine($"r1: {r1}");

            r1.Move(2, 1);

            Console.WriteLine($"r1: {r1}");
        }
    }
}