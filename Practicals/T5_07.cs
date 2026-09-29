using System;

namespace Practicals
{
    class T5_07
    {
        public static void T5_07Main()
        {
            int[] arr = { 40, 50, 60, 70 };
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] % 2 == 0)
                        evenCount++;
                    else
                        oddCount++;
                }
                int[] even = new int[evenCount];
                int[] odd = new int[oddCount];

                int e = 0;
                int o = 0;

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
            }
        }
    }