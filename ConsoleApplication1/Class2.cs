using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    partial class Student
    {
        public int Day { get; set; }

        private int Month;

        public int Month1
        {
            get { return Month; }
            set
            {
                if (value <= 12)
                    Month = value;
            }
        }


        public void Print2()
        {
            Console.WriteLine($"Day = {Day}, Month = {Month}");
        }
    }

}
