using System;

namespace Practicals
{
    class Employee
    {
        private int empId;
        private string name;
        private double salary;
        private double netSalary;

        //Parameterized Constructor
        public Employee(int id, string n, double s)
        {
            empId = id;
            name = n;
            salary = s;
        }

        public void CalculateSalary()
        {
            double hra = 0.20 * salary;
            double da = 0.10 * salary;
            netSalary = hra + salary + da;
        }

        public void Display()
        {
            Console.WriteLine("\n----Employee Details----");
            Console.WriteLine("Employee ID is " + empId);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Salary is " + salary);
            Console.WriteLine("Net Salary is " + netSalary);
        }
    }
    class T3_10
    {
        public static void T3_10Main()
        {
            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string n = Console.ReadLine();

            Console.Write("Enter Base Salary: ");
            double s = Convert.ToDouble(Console.ReadLine());

            Employee e = new Employee(id, n, s);
            
            e.CalculateSalary();
            e.Display();
        }
    }
}