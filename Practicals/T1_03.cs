using System;

namespace Practicals
{
    internal class T1_03
    {
        public static void OddEvenMain()
        {
            int num;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
