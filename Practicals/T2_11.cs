using System;

namespace Practicals
{
    internal class T2_11
    {
        public static void SumOfArray()
        {
            int n, sum = 0;
            Console.Write("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter elements: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("Sum of elements: {0}", sum);
        }
    }
}