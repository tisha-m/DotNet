using System;

namespace Practicals
{
    internal class PrintAsInput
    {
        public static void PrintAsInputMain()
        {
            String name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Output: " + name);
        }
    }
}
