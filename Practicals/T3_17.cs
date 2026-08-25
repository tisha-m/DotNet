using System;

namespace Practicals
{
    //Base class
    class Shape
    {
        private double area;

        //Virtual keyword used in parent's class method
        public virtual void CalculateArea()
        {
            Console.WriteLine("Area of shape");
        }
    }

    class Circle : Shape 
    {
        public override void CalculateArea()
        {
            double radius = 5;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle: " + area);
        }
    }

    class Rectangle : Shape 
    {
        public override void CalculateArea()
        {
            double length = 10;
            double width = 20;
            double area = length * width;
            Console.WriteLine("Area of circle: " + area);
        }
    }

    class Triangle : Shape
    {
        public override void CalculateArea()
        {
            double b = 5;
            double h = 10;
            double area = 0.5 * b * h;
            Console.WriteLine("Area of circle: " + area);
        }
    }

    class T3_17
    {
        public static void T3_17Main()
        {
            Shape s;

            s = new Circle();
            s.CalculateArea();

            s = new Rectangle();
            s.CalculateArea();

            s = new Triangle();
            s.CalculateArea();
        }
    }
}