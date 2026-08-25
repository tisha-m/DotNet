using System;

namespace Practicals
{
    class Students21
    {
        protected int roll_no;
        protected string name;

        public Students21(int roll_no, string name)
        {
            this.roll_no = roll_no;
            this.name = name;
        }
    }

    class StudentDetails21 : Students21 
    {
        private int age;

        public StudentDetails21(int roll_no, string name, int age) : base(roll_no, name) 
        {
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Roll number: " + roll_no);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
    class T3_21
    {
        public static void T3_21Main()
        {
            StudentDetails21 s1 = new StudentDetails21(1, "Tisha", 19);
            StudentDetails21 s2 = new StudentDetails21(2, "Titu", 19);

            s1.Display();
            s2.Display();
        }
    }
}