using System;

namespace Practicals
{
    internal class SumOf3
    {
        public static void SumOf3Main()
        {
            Console.Write("Enter 1 Number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter 2 Number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter 3 Number: ");
            int c = int.Parse(Console.ReadLine());

            int ans = a + b + c;

            Console.WriteLine("Sum of 3 Numbers is: " + ans);
        }
    }
}