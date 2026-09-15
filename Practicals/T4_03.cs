using System;

namespace Practicals
{
    class Person4
    {
        private string name;
        protected int age;
        public string address;

        //constructor
        public Person4(string n, int a, string add)
        {
            name = n;
            age = a;
            address = add;
        }

        public void showName()
        {
            Console.WriteLine("Name: " + name);
        }
        public void showAge()
        {
            Console.WriteLine("Age: " + age);
        }
        public void showAddress()
        {
            Console.WriteLine("Address: " + address);
        }
    }

    class Student4 : Person4
    {
        private int rollNo;
        protected string branch;
        public double marks;

        public Student4(string name, int age, string address, int roll, string br, double m) : base(name, age, address)
        {
            rollNo = roll;
            branch = br;
            marks = m;
        }
        public void showRollNo()
        {
            Console.WriteLine("Roll No: " + rollNo);
        }
        public void showBranch()
        {
            Console.WriteLine("Branch: " + branch);
        }
        public void showMarks()
        {
            Console.WriteLine("Marks: " + marks);
        }

        //method to call all student details
        public void DisplayStudent()
        {
            showName();
            showAge();
            showAddress();
            showRollNo();
            showBranch();
            showMarks();
        }
    }
    class T4_03
    {
        public static void T4_03Main()
        {
            Student4 s1 = new Student4("Tisha", 19, "Porbandar", 46, "CE", 89.0);
            s1.DisplayStudent();

            Student4 s2 = new Student4("Titu", 20, "Bhuj", 38, "CE", 90.0);
            s2.DisplayStudent();
        }
    }
}
