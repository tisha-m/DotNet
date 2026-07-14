using System;

namespace Practicals
{

    internal class T1_21
    {
        public static void SumSeriesMain()
        {
            int terms, number;
            int sum = 0;
            int current = 0;

            Console.Write("Enter terms: ");
            terms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter input number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= terms; i++)
            { 
                current = current * 10 + number;
                Console.Write(current);
                sum += current;

                if (i < terms)
                { Console.Write(" + "); }
            }
            Console.WriteLine();
            Console.WriteLine("Sum is: " + sum);
        }
    }
}