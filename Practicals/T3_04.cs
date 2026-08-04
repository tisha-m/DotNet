using System;

namespace Practicals
{
    class Students4 
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

        public Students4() //Empty Constructor
        {
            id = 0;
            name = "Unknown";
        }
        public Students4(int i, string n) //Parameterized Constructor
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

    internal class T3_04
    {
        public static void T3_04Main()
        {
            //Creating objects
            Students4 s1 = new Students4(101, "Tisha");
            Students4 s2 = new Students4(102, "Titu");
            Students4 s3 = new Students4(103, "Deval");
            Students4 s4 = new Students4(104, "Roshni");

            //Displaying values
            s1.display();
            s2.display();
            s3.display();
            s4.display();
        }
    }
}