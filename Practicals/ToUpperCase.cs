using System;

namespace Practicals
{
    internal class ToUpperCase
    {
        public static void ToUpperCaseMain()
        {
            string name;
            Console.Write("Enter any string: ");
            name = Console.ReadLine();
            Console.WriteLine("The string in uppercase: " + name.ToUpper());
        }
    }
}
