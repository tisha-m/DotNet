using System;

namespace Practicals
{
    internal class Table
    {
        //public static void TableMain()
        //{
        //    Console.Write("Enter a Number: ");
        //        int n = int.Parse(Console.ReadLine());
        //        for (int i = 1; i <= 10; i++)
        //        {
        //            Console.WriteLine(n + " * " + i + " = " + (n * i));
        //        }
        //    }


        public static void TableMain()
        {
            Console.Write("Enter 1 Number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2 Number: ");
            int n2 = int.Parse(Console.ReadLine());
            for (int j = n1; j <= n2; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(j + " * " + i + " = " + (j * i));
                }
                Console.WriteLine();
            }
        }
    }
}
