using System;

namespace Practicals
{
    public class A // This is the base class.
    {
        public A(int value)
        {
            Console.WriteLine("Base constructor A()");
        }
    }

    public class B : A // This class derives from the previous class.
    {
        public B(int value) : base(value)
        {
            Console.WriteLine("Derived constructor B()");
        }
    }

    class T4_05
    {
        public static void T4_05Main()
        {
            // Create a new instance of class A, which is the base class.

            // ... Then create an instance of B, which executes the base constructor.

            A a = new A(5);
            B b = new B(10);

        }
    }
}