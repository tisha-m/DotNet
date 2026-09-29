using System;

namespace Practicals
{
	class T5_01
    {
        public static void T5_01Main()
        {
            int[] arr = { 40, 50, 60, 70 };
            Console.Write("Array items: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            //individual element print
            Console.WriteLine("\nThird Element in the array: " + arr[2]);
        }
    }
}