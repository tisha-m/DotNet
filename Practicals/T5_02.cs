using System;

namespace Practicals
{
	class T5_02
	{
		public static void T5_02Main()
		{
			int[] arr = new int[5];
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("Enter the elements: ");
				arr[i] = Convert.ToInt32(Console.ReadLine());
            }
			Array.Sort(arr);
			Console.WriteLine("Sorted array in ascending order: ");
            for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + ", ");
			}
		}
	}
}