using System;

namespace Practicals
{
    class T5_09
    {
        public static void T5_09Main()
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            int pos = 3;

            for (int i = pos - 1; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i+1];
            }

            Console.WriteLine("Array after deletion: ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]+ " ");
            }

        }
    }
}