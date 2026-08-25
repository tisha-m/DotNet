using System;

namespace Practicals
{
    class Students20
    {
        private int roll_no;
        private string name;

        //Constructor
        public Students20(int roll_no, string name)
        {
            this.roll_no = roll_no;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("\n-----Student Details-----");
            Console.WriteLine("Roll number is: " + roll_no);
            Console.WriteLine("Name is: " + name);
        }
    }
    class T3_20
    {
        public static void T3_20Main()
        {
            Students20 s1 = new Students20(1, "Tisha");
            Students20 s2 = new Students20(2, "Titu");

            s1.Display();
            s2.Display();
        }
    }
}