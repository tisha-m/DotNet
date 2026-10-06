using System;

namespace Practicals
{
    class T5_08
    {
        public static void T5_08Main()
        {
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter elements: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Array.Sort(arr);
            //Array.Reverse(arr);

            Console.WriteLine("Descending order: ");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}