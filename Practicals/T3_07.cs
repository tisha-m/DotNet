using System;

namespace Practicals
{
    class Students
    {
        private int enroll;
        private string name;

        //Parameterized Constructor
        public Students(int e, string n)
        {
            enroll = e;
            name = n;
        }
        public void Display()
        {
            Console.WriteLine("Enrollment Number is " + enroll);
            Console.WriteLine("Name is " + name);
        }
    }
    class T3_07
    {
        public static void T3_07Main()
        { 
            Console.Write("Enter Enrollment Number: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string n = Console.ReadLine();
            Students s = new Students(e, n);
            s.Display();
        }
    }
}