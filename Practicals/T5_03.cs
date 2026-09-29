using System;

namespace Practicals
{
	public class T5_03
	{
		public static void T5_03Main() 
		{
            Console.Write("Enter the number of elements: ");
			int n = Convert.ToInt32(Console.ReadLine());
			
			int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the elements: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine("Reverse order: " + arr[i]);
            }
        }
	}
}