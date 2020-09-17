using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    

    partial class Student
    {
        public static int Age;
        public string Name;
        public readonly int[] Mark = { 3, 4, 5 };

        
            static Student()
        {
            Age = 12;
        }

        public Student() : this("No name", 0)
        {

        }
        public Student(string n, int a)
        {
            Age = a;
            this.Name = n;
        }


        public void Print()
        {
            Console.WriteLine($"Name = {Name}, Age = {Age}");
        }

        static void PrintStar()
        {

            //Console.WriteLine($"Name = {Name}, Age = {Age}");
        }

        //public void Funk1(MyClass2 cl)
        //{
        //    cl.Funk2(this);
        //}
    }

}
