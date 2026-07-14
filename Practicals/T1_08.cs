using System;

namespace Practicals
{
    internal class T1_08
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
