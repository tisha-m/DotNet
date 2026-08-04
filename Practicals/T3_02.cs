using System;

namespace Practicals
{
    class Clock
    {
        private int hour;
        private int min;
        private int sec;

        //Empty/Default Constructor
        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        //Parameterized Constructor
        public Clock(int h, int m, int s)
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
            Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}:");
        }

        //Return hour
        public int gethour()
        {
            return hour;
        }

        //Return minutes
        public int getmin()
        {
            return min;
        }

        //Return seconds
        public int getsec()
        {
            return sec;
        }
    }

        internal class T3_02
        {
            public static void T3_02Main()
            {
                Clock c1 = new Clock(); //Creating object
                Console.Write("Default Time: ");
                c1.display(); //Displaying values

                Clock c2 = new Clock(10, 59, 58); //Creating object
                Console.Write("Initial Time: ");
                c2.display(); //Displaying values

                c2.incrementSecond();
                Console.Write("After 1 Second: ");
                c2.display(); //Displaying values

                c2.incrementSecond();
                Console.Write("After 2 Seconds: ");
                c2.display();//Displaying values

                //Displaying individual values
                Console.WriteLine("Hour: " + c2.gethour());
                Console.WriteLine("Minutes: " + c2.getmin());
                Console.WriteLine("Seconds: " + c2.getsec());
            }
        }
    }