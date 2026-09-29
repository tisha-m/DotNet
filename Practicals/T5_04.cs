using System;

namespace Practicals
{
    class T5_04
    {
        public static void T5_04Main()
        {
            int[] arr1 = { 50, 60, 70, 80 };
            int[] arr2 = { 10, 20, 30, 40 };

            Array.Copy(arr1, arr2, arr1.Length);
            Console.Write("Array 1 items: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + ", ");
            }
            Console.Write("\nCopying the items of Array 1 to Array 2: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}