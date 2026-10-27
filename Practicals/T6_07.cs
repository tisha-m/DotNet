using System;

namespace Practicals
{
    class T6_07
    {
        public static void T6_07Main()
        {
            try
            {
                Console.Write("Enter a number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: Invalid format " + e);
            }
            finally
            {
                Console.WriteLine("Format execution implemented.");
            }
        }
    }
}