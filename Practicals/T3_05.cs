//using System;

//namespace Practicals

//{

//    class Product
//    {
//        int pcode;
//        string pname, mname;

//        public Product(int pcd, string pnm, string mnm)
//        {
//            pcode = pcd;
//            pname = pnm;
//            mname = mnm;
//        }

//        public void Display()
//        {
//            Console.WriteLine("Mandaviya Tisha Jayesh - 25SOECE13066\n");

//            Console.WriteLine("\nProduct Code:= " + pcode);
//            Console.WriteLine("\nProduct Name:= " + pname);
//            Console.WriteLine("\nManufacturer Name:= " + mname);
//        }
//    }

//    public class T3_05
//    {
//        public static void Main(string[] args)

//        {
//            if (args.Length < 3)
//            {
//                Console.WriteLine("Syntax Error\n");
//                return;
//            }
//            int pcd = Convert.ToInt32(args[0]);
//            string pnm = args[1];
//            string mnm = args[2];
//            Product p = new Product(pcd, pnm, mnm);
//            p.Display();

//        }

//    }

//}