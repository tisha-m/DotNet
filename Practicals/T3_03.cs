using System;

namespace Practicals
{
    class Students3
    {
        public int id;
        public string name;

        //Properties
        public int Id
        {
            get { return id; }  //get value read
            set { id = value; } //set value write
        }

        //Properties
        public string Name
        {
            get { return name; }  //get value read
            set { name = value; } //set value write
        }

        public Students3() //Empty Constructor
        {
            id = 0;
            name = "Unknown";
        }
        public Students3(int i, string n) //Parameterized Constructor
        {
            id = i;
            name = n;
        }

        public void display() 
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
        }
     }

    internal class T3_03
    {
        public static void T3_03Main()
        {
            Console.WriteLine("Empty Constructor");
            Students3 s1 = new Students3(); //Creating object
            s1.display();
            Console.WriteLine("Parameterized Constructor");
            Students3 s2 = new Students3(101, "Tisha"); //Creating object
            s2.display();
        }
    }
}