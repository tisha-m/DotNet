using System;
using System.Collections.Generic;
using System.Text;

namespace Practicals
{
    //BASE CLASS
    class Student22
    {
        private string course;

        public void DisplayDetails()
        {
            Console.WriteLine("My Course is BTech-CE");
        }
    }

    //DERIVED CLASS
    class Stu : Student22
    {
        public new void DisplayDetails()
        {
            Console.WriteLine("My Course is MTech-CE");
        }
    }

    class T3_22
    {
        public static void T3_22Main()
        {
            Stu s1 = new Stu();
            s1.DisplayDetails(); // Calls the derived class method
        }
    }
}