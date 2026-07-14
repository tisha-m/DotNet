using System;

namespace Practicals
{
    internal class T2_03
    {
        public static void T2_3Main()
        {
            char firstName = 'M';
            char lastName = 'D';
            
            Console.WriteLine("Name: " + firstName + " " + lastName);
             
            Console.Write("Please enter a new first name: ");
            firstName = Convert.ToChar(Console.ReadLine());

            Console.Write("New name: " + firstName + " " + lastName);
        }
    }
}