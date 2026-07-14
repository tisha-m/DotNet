using System;

namespace Practicals
{
    internal class DiamondPattern
    {
        public static void DiamondPatternMain()
        {
            int i, j, k;
            int rows = 5;
            for (i = 1; i <= rows; i++)
            {
                for (j = i; j < rows; j++) 
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= (2 * i - 1); k++)
                { 
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = rows - 1; i >= 1; i--)
            {
                for (j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}