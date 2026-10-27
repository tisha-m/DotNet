using System;
using System.Collections.Generic;
using System.Linq;

namespace Practicals
{
    class Student12 
    {
        public int Id { get; set;  }
        public string Name { get; set;  }
        public string Course { get; set;  }
        public int Marks { get; set; }

    }
    class T6_12
    {
        public static void T6_12Main()
        {
            List<Student12> students = new List<Student12>()
            {
                new Student12 { Id = 1, Name = "Tisha", Course = "BTech", Marks = 80},
                new Student12 { Id = 2, Name = "Priyanka", Course = "BTech", Marks = 85},
                new Student12 { Id = 3, Name = "Aisha", Course = "BTech", Marks = 65}
            };

            var result = from s in students
                         where s.Marks > 70
                         orderby s.Marks
                         select s;

            Console.WriteLine("Students having marks greater than 70: ");

            foreach (Student12 s in result)
            {
                Console.WriteLine(s.Id + " " + s.Name + " " + s.Course + " " + s.Marks);
            }

        }
    }
}