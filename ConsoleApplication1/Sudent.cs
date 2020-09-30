using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StudentCard
    {
        public string Series { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return $"Student Card: {Series}  {Number}";
        }
    }


   class Student1: IComparable, ICloneable
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }

        public StudentCard StudentCard { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, BirthDay: {BirthDay.ToShortDateString()}, {StudentCard}";
        }

        public int CompareTo(object obj)
        {
            return Name.CompareTo((obj as Student1).Name);
        }

        public object Clone()
        {
            Student1 temp = (Student1)this.MemberwiseClone();
            temp.StudentCard = new StudentCard
            {
                Series = this.StudentCard.Series,
                Number = this.StudentCard.Number
            };
            return temp;
        }
    }
    


    class Group: IEnumerable
    {
        Student1[] students =
        {
           new Student1
            {
                Name = "Tatyana",
                BirthDay = new DateTime(1980, 12, 16),
                StudentCard = new StudentCard
                {
                    Series = "AA",
                    Number = 123456
                }
            },
           new Student1
            {
                Name = "Ivan",
                BirthDay = new DateTime(1983, 10, 10),
                StudentCard = new StudentCard
                {
                    Series = "AB",
                    Number = 653421
                }
            },
           new Student1
            {
                Name = "Olga",
                BirthDay = new DateTime(1983, 12, 20),
                StudentCard = new StudentCard
                {
                    Series = "AA",
                    Number = 654321
                }
            },
           new Student1
            {
                Name = "Nikolay",
                BirthDay = new DateTime(1980, 5, 25),
                StudentCard = new StudentCard
                {
                    Series = "CA",
                    Number = 123456
                }
            },
        };

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }

    }

    class DateComparer : IComparer
    {
       public int Compare(object x, object y)
        {
            if(x is Student1 && y is Student1)
            return DateTime.Compare((x as Student1).BirthDay, (y as Student1).BirthDay);
            else if (x is Employee && y is Employee)
                return DateTime.Compare((x as Employee).BirthDay, (y as Employee).BirthDay);
            throw new NotImplementedException("Только джля класса Student1");
        }
    }

    class StudentCardComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            StudentCard st1 = (x as Student1).StudentCard;
            StudentCard st2 = (y as Student1).StudentCard;
            if (st1.Series != st2.Series)
                return st1.Series.CompareTo(st2.Series);
            else
                return st1.Number.CompareTo(st2.Number);
        }
    }




}



public class MyException : ApplicationException
{
    public DateTime DateTime_ { get; set; }

    public MyException()
    {
        DateTime_ = DateTime.Now;
    }
}
