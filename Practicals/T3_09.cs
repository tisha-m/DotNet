using System;

namespace Practicals
{
    class Current_Clock
    {
        private int hour;
        private int min;
        private int sec;

        //Empty/Default Constructor
        public void Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        //Parameterized Constructor
        public void Clock(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }
        //Increment time to next second
        public void incrementSecond()
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
                if (min == 60)
                {
                    min = 0;
                    hour++;
                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }

        //Display time
        public void display()
        {
            Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
        }
    }

    internal class T3_09
    {
        public static void T3_09Main()
        {
            Clock c2 = new Clock(10, 59, 59); //Creating object
            
            Console.Write("Current Time: ");
            c2.display(); //Displaying values

            c2.incrementSecond();

            Console.Write("After Increment: ");
            c2.display(); //Displaying values
        }
    }
}