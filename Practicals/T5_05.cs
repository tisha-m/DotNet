using System;

namespace Practicals
{
    class T5_05
    {
        public static void T5_05Main()
        {
            int[] arr = { 40, 50, 60, 70, 40, 60, 80 };
            int duplicateCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool alreadyChecked = false;

                //check whether that element appeared before
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        alreadyChecked = true;
                        break;
                    }
                }
                if (alreadyChecked)
                    continue;

                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine(arr[i] + " occurs " + count + " times ");
                    duplicateCount++;
                }
            }
            Console.WriteLine("Number of duplicate items: " + duplicateCount);
        }
    }
}