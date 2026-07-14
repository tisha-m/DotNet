using System;

namespace Practicals
{
    internal class ToToggleCase
    {
        public static void ToToggleCaseMain()
        {
            string str;
            string result = "";
            Console.Write("Enter a string: ");
            str = Console.ReadLine();

            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    result += char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    result += char.ToUpper(c);
                }
                else
                { 
                    result += c;
                }
                Console.Write("Toggled String; " + result);
            }
        }
    }
}
