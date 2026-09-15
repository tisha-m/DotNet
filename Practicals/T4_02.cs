using System;

namespace Practicals
{
    //Base class or Parent class.

    class Shape4

    {
        public double Width;
        public double Height;

        public void ShowDim()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }
    }

    // Triangle is derived from Shape.

    //Drived class or Child class.

    class Triangle4 : Shape4

    {

        public string Style; // style of triangle

        // Return area of triangle.      

        public double area()
        {
            return Width * Height / 2;
        }

        // Display a triangle's style.

        public void ShowStyle()

        {
            Console.WriteLine("Triangle is " + Style);
        }
    }

    //Driver class which runs the program.

    class T4_02

    {
        public static void T4_02Main()

        {
            Triangle4 t1 = new Triangle4();
            Triangle4 t2 = new Triangle4();
            t1.Width = 4.0;
            t1.Height = 4.0;
            t1.Style = "isosceles";

            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "right";

            Console.WriteLine("Info for t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area is " + t1.area());
            Console.WriteLine();

            Console.WriteLine("Info for t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area is " + t2.area());
        }
    }
}