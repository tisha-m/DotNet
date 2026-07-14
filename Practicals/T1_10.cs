using System;

namespace Practicals
{
    internal class T1_10
    {
        public static void ToMobileNumMain()
        {
            string number;
            Console.Write("Enter phone number: ");
            number = Console.ReadLine();

            if (number.Length>=5)
            { 
                string result = number.Substring(0, number.Length - 5) + "XXXXX";
                Console.Write("Masked phone number: " + result);
            }
        }
    }
}
