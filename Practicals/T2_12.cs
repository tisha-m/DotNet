using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals
{
    internal class T2_12
    {
        public static void SearchOfElements()
        {
            int n, search;
            int found = 0;
            Console.Write("Enter the number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Element {0}: ", i);

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter element to search: ");
            search = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == search)
                {
                    found = 1;
                    break;
                }
            }

            Console.WriteLine(found);
        }
    }
}