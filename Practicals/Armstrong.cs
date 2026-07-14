using System;

namespace Practicals
{
    internal class Armstrong
    {
        public static void ArmstrongMain()
        {
            int number, original, remainder, result = 0;
            Console.Write("Enter any number: ");
            number = Convert.ToInt32(Console.ReadLine());

            original = number;
            while (number != 0)
            {
                remainder = number % 10;
                result = result + (remainder * remainder * remainder);
                number = number / 10;
            }
            if (original == result)
            {
                Console.Write("This is an armstrong number.");
            }
            else
            { 
                Console.Write("This is not an armstrong number.");
            }
    }
}
}
