using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfC_Sharp
{
    class StructVsClass {

        public void Implement() {
            Point point = new Point();
            point.x = 23;
            point.y = 30;
            Point point1 = point;
            point1.x = 40;
            point1.y = 50;

            Console.WriteLine("First Point is : {0},{1}",point.x,point.y);
            Console.WriteLine("Second point is : {0},{1}",point1.x,point1.y);


            Student student = new Student();
            student.Name = "Zahid Ahmed";
            student.Age = 21;

            Student student1 = student;
            student1.Name = "Saddam hossain";
            student1.Age = 23;

            Student student2 = student1;
            student2.Name = "Ashraful Islam";
            student2.Age = 22;

            Console.WriteLine("First Student is : {0},{1}", student.Name , student.Age);
            Console.WriteLine("Second Student is : {0},{1}", student1.Name , student1.Age);
            Console.WriteLine("Third Student is : {0},{1}", student2.Name, student2.Age);

        }
        
    }

    struct Point {
        public int x, y;
    }

    public class Student {
        public string Name;
        public int Age;
    }
}
