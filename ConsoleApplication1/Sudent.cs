using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public delegate void ExamDelegate(string st);

    class StudentCard
    {
        public string Series { get; set; }
        public int Number { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"Student Card: {Series}  {Number}";
        }
    }


    class Student1 : IComparable, ICloneable
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Surname { get; set; }

        public StudentCard StudentCard { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}BirthDay: {BirthDay.ToShortDateString()}, {StudentCard}";
        }

        public int CompareTo(object obj)
        {
            return Name.CompareTo((obj as Student1).Name);
        }

        public int IDGroup { get; set; }

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

        public void Exam(string date)
        {
            Console.WriteLine($"Студенту {Surname} {Name} назначен экзамен на {date}");
        }

    }

    class Teacher
    {
        SortedList<string, ExamDelegate> list = new SortedList<string, ExamDelegate>();

        public event ExamDelegate examEvent
        {
            add { list.Add((value.Target as Student1).Name, value); }
            remove { list.Remove((value.Target as Student1).Name); }
        }

        public void SetExam(string date)
        {
            foreach (var item in list.Values)
            {
                item(date);
            }
            //examEvent?.Invoke(date);
            //if (examEvent != null)
            //    examEvent(date);
        }
    }

    class GroupSt
    {
        public  int ID { get; set; }
        public string Name { get; set; }

    }

    class Group
    {
        Point2D<int>[] points = new Point2D<int>[]
        {
            new Point2D<int>(3,5),
            new Point2D<int>(4,8),
            new Point2D<int>(8,9)
        };

        public IEnumerable GetPoints()
        {
            for (int i = 0; i < points.Length; i++)
            {
                yield return points[i];
            }
        }

        Student1[] students =
        {
           new Student1
            {
                Name = "Tatyana",
                Surname = "Pushka",
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
                Surname = "Richard",
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
                Surname = "Killer",
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
                Surname = "Nemov",
                BirthDay = new DateTime(1980, 5, 25),
                StudentCard = new StudentCard
                {
                    Series = "CA",
                    Number = 123456
                }
            },
        };

        public IEnumerator<Student1> GetEnumerator()
        {
            for (int i = 0; i < students.Length; i++)
            {
                yield return students[i];
            }
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

    class DateComparer : IComparer<Student1>, IComparer<Employee>
    {
        public int Compare(Student1 x, Student1 y)
        {
            return DateTime.Compare(x.BirthDay, y.BirthDay);
        }

        public int Compare(Employee x, Employee y)
        {
            return DateTime.Compare(x.BirthDay, y.BirthDay);
        }
    }

    class SurnameComparer : IComparer<Student1>
    {
        public int Compare(Student1 x, Student1 y)
        {
            return x.Surname.CompareTo(y.Surname);

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


    public class MyException : ApplicationException
    {
        public DateTime DateTime_ { get; set; }

        public MyException()
        {
            DateTime_ = DateTime.Now;
        }
    }


    class Garbage : IDisposable
    {
        public void OpenDB()
        {
            Console.WriteLine("Open DB");
            Console.WriteLine("Create Table.....");
            //throw new Exception("No responce");
        }
        public void CreatGarbage()
        {
            for (int i = 0; i < 100000; i++)
            {
                Student1 p = new Student1();
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Dispos DB");
        }
    }

}




