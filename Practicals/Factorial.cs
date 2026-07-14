using System;

namespace Practicals {

    internal class  Factorial
    {
        public static void FactMain()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of " + num + " is: " + fact);
        }
    }
}