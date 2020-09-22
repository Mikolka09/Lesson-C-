using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human1
{
   public abstract class Human
    {
        protected string Name;
        protected int Age;

        public Human(string n, int a)
        {
            Name = n;
            Age = a;
        }

        public abstract void WhoAmI();

        public virtual void Print()
        {
            Console.Write($"Name - {Name}, Age - {Age}");
        }
    }

    public class Employee : Human
    {
        double Salary;
        public Employee(string n, int a, double s) : base(n, a)
        {

            Salary = s;
        }

        public override void WhoAmI()
        {
            Console.Write($"I Employee");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Salary - {Salary}");
        }
    }

    public class Scientist : Human
    {
        string ScientificTitle;

        public Scientist(string n, int a, string st) : base(n, a)
        {
            ScientificTitle = st;
        }
        public override void WhoAmI()
        {
            Console.Write($"I Scientist");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" ScientificTitle - {ScientificTitle}");
        }
    }

   public  class Student1 : Scientist
    {
        //new string Name;
        int StudentCard;

        public Student1(string n, int a, int sc) : base(n, a, "Student1")
        {
            StudentCard = sc;
            //Name = "Borya";
        }
        public override void WhoAmI()
        {
            Console.Write($"I Student1");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"StudentCard - {StudentCard}");//, Name - {Name}");
        }
    }

    //class Stu2 :Student1
    //{
    //    public Stu2(string n, int a, int sc):base(n, a, sc)
    //    {

    //    }
    //    public override void Print()
    //    {
    //        base.Print();
    //        Console.WriteLine($"StudentCard");//, Name - {Name}");
    //    }
    //}
}
