using System;

namespace Practicals
{
    class T5_07
    {
        public static void T5_07Main()
        {
            int[] arr = { 10, 15, 20, 25, 30, 35, 40 };
            int[] even = new int[arr.Length];
            int[] odd = new int[arr.Length];
            int e = 0, o = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                { 
                    even[e] = arr[i];
                    e++;
                }
                else
                {
                    odd[o] = arr[i];
                    o++;
                }
            }
            Console.WriteLine("Even elements: ");
            for (int i = 0; i < e; i++)
            { 
                Console.Write(even[i] + " ");
            }

            Console.WriteLine("\nOdd elements: ");
            for (int i = 0; i < o; i++)
            {
                Console.Write(odd[i] + " ");
            }

        }
    }
}