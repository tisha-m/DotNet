using System;

namespace Practicals
{
    class StaticVar
    {
        public static int num;

        // Fixed: Added void return type and renamed to match s.count() call
        public void count()
        {
            num++;
        }

        // Filled: Missing statement for the static getNum method
        public static int getNum()
        {
            return num;
        }
    }

    class T4_04
    {
        public static void T4_04Main()
        {
            StaticVar s = new StaticVar();
            s.count();
            s.count();
            s.count();

            Console.WriteLine("Variable num: {0}", StaticVar.getNum());
        }
    }
}