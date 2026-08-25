using System;

namespace Practicals
{
    class Students19
    {
        static int count = 0;

        //Constructor
        public Students19()
        {
            count++;
        }

        public static void DisplayCount()
        {
            Console.WriteLine("Total number of Students: " + count);
        }
    }
    class T3_19
    {
        public static void T3_19Main()
        {
            Students19 s1 = new Students19();
            Students19 s2 = new Students19();
            Students19 s3 = new Students19();
            Students19 s4 = new Students19();
            Students19 s5 = new Students19();
            Students19 s6 = new Students19();
            Students19 s7 = new Students19();
            Students19 s8 = new Students19();
            Students19 s9 = new Students19();
            Students19 s10 = new Students19();

            Students19.DisplayCount();
        }
    }
}