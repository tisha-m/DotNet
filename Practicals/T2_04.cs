using System;

namespace Practicals
{
    internal class T2_04
    {
        public static void T2_4Main()
        {
            int a, b;
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("------Arithmetic Operators------");
            Console.WriteLine("Addition is: " + (a+b));
            Console.WriteLine("Subtraction is: " + (a-b));
            Console.WriteLine("Multiplication is: " + (a*b));
            Console.WriteLine("Divison is: " + (a/b));

            Console.WriteLine();
            Console.WriteLine("------Relational Operators------");
            Console.WriteLine("a<b: " + (a < b));
            Console.WriteLine("a>b: " + (a > b));
            Console.WriteLine("a==b: " + (a == b));
            Console.WriteLine("a!=b: " + (a != b));

            Console.WriteLine();
            Console.WriteLine("------Logical Operators------");
            Console.WriteLine("a>b && a<b: " + (a > b && a < b));
            Console.WriteLine("a>b || a<b: " + (a > b || a < b));
            Console.WriteLine("!(a==b): " + !(a==b));
        }
    }
}