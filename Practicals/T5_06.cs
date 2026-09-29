using System;

namespace Practicals
{
    class T5_06
    {
        public static void T5_06Main()
        {
            int[] arr = { 40, 50, 60, 70 };
            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine("Maximum Element in the array: " + max);
            Console.WriteLine("Minimum Element in the array: " + min);
        }
    }
}