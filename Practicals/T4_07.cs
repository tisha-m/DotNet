using System;

namespace Practicals
{
    class A1
    {
        public int x;
        public int y;
    }

    class B1 : A1
    {
        public int z;
    }

    class T4_07
    {
        public static void T4_07Main()
        {
            A1 sc = new A1();
            sc.x = 110;
            sc.y = 150;
            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        }
    }
}