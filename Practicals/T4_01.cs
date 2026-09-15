using System;

namespace Practicals
{
    class Employee4
    {
        private int empCode;
        private string name;
        private string designation;
        private double basicPay;
        private double hra, da, totalPay;

        //Parameterized Constructor
        public Employee4(int code, string nm, string desig, double pay)
        {
            empCode = code;
            name = nm;
            designation = desig;
            basicPay = pay;
        }

        public void calculate()
        {
            hra = 0.20 * basicPay;
            da = 0.10 * basicPay;
            totalPay = hra + basicPay + da;
        }

        public void display()
        {
            Console.WriteLine("\n----Employee Details----");
            Console.WriteLine("Code: " + empCode);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Basic Pay: " + basicPay);
            Console.WriteLine("HRA(10%): " + hra);
            Console.WriteLine("DA(45%): " + da);
            Console.WriteLine("Total Pay: " + totalPay);
        }
    }
    class T4_01
    {
        public static void T4_01Main()
        {
            Employee4 e = new Employee4(101, "Tisha", "Developer", 50000);
            e.calculate();
            e.display();

            Employee4 ee = new Employee4(102, "Titu", "Developer", 50000);
            e.calculate();
            e.display();
        }
    }
}