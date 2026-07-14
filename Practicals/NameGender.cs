using System;

namespace Practicals
{
    internal class NameGender
    {
        public static void NameGenderMain()
        {
            string name;
            char gender;

            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter gender: ");
            gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M' || gender == 'm')
            {
                Console.WriteLine("Hello Mr. " + name);
            }
            else if (gender == 'F' || gender == 'f')
            {
                Console.WriteLine("Hello Ms. " + name);
            }
            else 
            {
                Console.WriteLine("Invalid gender input");
            }
        }
    }
}
