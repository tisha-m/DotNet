using System;

namespace Practicals
{
    class Student
    {
        private int enroll;
        private string name;
        private string course;
        private int age;

        //Parameterized Constructor
        public Student(int e, string n, string c, int a)
        {
            enroll = e;
            name = n;
            course = c;
            age = a;
        }
        public void Display()
        {
            Console.WriteLine("\n----Student Details----");
            Console.WriteLine("Enrollment Number is " + enroll);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Course is " + course);
            Console.WriteLine("Age is " + age);
        }
    }
    class T3_08
    {
        public static void T3_08Main()
        {
            Console.Write("Enter Enrollment Number: ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string n = Console.ReadLine();

            Console.Write("Enter Course: ");
            string c = Console.ReadLine();

            Console.Write("Enter Age: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Student s = new Student(e, n, c, a);
            s.Display();
        }
    }
}