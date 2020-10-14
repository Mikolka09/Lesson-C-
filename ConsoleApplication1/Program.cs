using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NS = NS2.NS3;
using Human1;
using System.Collections;
using OperationTimer;
using System.IO;

namespace ConsoleApplication1
{
    //enum DayOfWeek: long
    //{
    //    Monday= 10000000000, Tuesday, Wednesday, Thursday, Friday, Saturday, Sanday
    //}

    //struct MyStruct
    //{
    //    public int Age;
    //    public string Name;

    //    public MyStruct(int a, string n)
    //    {
    //        Age = a;
    //        Name = n;
    //    }
    //}


    class MyClass
    {
        public void print()
        {
            Console.WriteLine("ConsoleApplication1");
        }
    }

    //class MyClass2
    //{
    //    public void Funk2(Student st)
    //    {
    //        st.Print();
    //    }
    //}

    //public delegate int IntDelegate(int a, int b);
    //public delegate double DoubleDelegate(double a, double b);
    public delegate int MyDelegate(int a, int b);
    public delegate void VoidDelegate();
    public delegate void StudentDelegate(string t);



    class Program
    {

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static double Sub(double a, double b)
        {
            return a - b;
        }

        static void M()
        {
            Console.WriteLine("Delegate");
        }

        static void Func1(ref int[] arr, out int a)
        {
            arr = new int[] { 4, 5, 6 };
            //arr[0] = 99;
            a = 88;
        }

        static void Print(Hashtable group)
        {
            foreach (Student1 student in group.Keys)
            {
                Console.Write(student + " Mark: ");
                foreach (int item in (group[student]) as ArrayList)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        static void AddMark(Hashtable group, string name, int mark)
        {
            foreach (Student1 student in group.Keys)
            {
                if (student.Name == name)
                    (group[student] as ArrayList).Add(mark);
            }
        }

        static T MaxElemArr<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            foreach (var item in arr)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }

        static T SummArr<T>(T[] arr) where T : struct
        {
            T sum = (dynamic)0;
            foreach (var item in arr)
            {

                sum += (dynamic)item;
            }
            return sum;
        }


        static void GetFullName(Student1 s)
        {
            Console.WriteLine($"{s.Name} {s.Surname}");
        }

        static string FullName(Student1 s)
        {
            return s.Surname + " " + s.Name;
        }

        static bool St80(Student1 st)
        {
            return st.BirthDay.Year > 1980;
        }

        static bool StSpring(Student1 st)
        {
            return st.BirthDay.Month > 2 && st.BirthDay.Month < 6;
        }

        static int SortByDate(Student1 a, Student1 b)
        {
            return DateTime.Compare(a.BirthDay, b.BirthDay);
        }

        static void Main(string[] args)
        {
            //Console.Beep(3000, 3000);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Clear();
            //Console.SetCursorPosition(10, 10);
            Console.WriteLine("Hello C#");
            Console.Title = "My C#";

            /////////////FILES/////////////////////////////

            //using (FileStream fs = new FileStream("test1.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    string str = Console.ReadLine();
            //    byte[] bytes = Encoding.Default.GetBytes(str);
            //    fs.Write(bytes, 0, bytes.Length);
            //}

            //using (FileStream fs = new FileStream("test1.bin", FileMode.Open, FileAccess.Read, FileShare.None))
            //{
            //    byte[] bytes = new byte[fs.Length];
            //    fs.Read(bytes, 0, bytes.Length);
            //    string str = Encoding.Default.GetString(bytes);
            //    Console.WriteLine(str);
            //}

            //using (FileStream fs = new FileStream("test2.txt", FileMode.Create))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
            //    {
            //        string str = Console.ReadLine();
            //        sw.WriteLine(str);
            //        foreach (var item in str)
            //        {
            //            sw.Write($"{item} + ");
            //        }
            //    }
            //}

            //using (FileStream fs = new FileStream("test2.txt", FileMode.Open))
            //{
            //    using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string str = sr.ReadLine();
            //            Console.WriteLine(str);
            //        }
            //    }
            //}

            //using (FileStream fs = new FileStream("test3.bin", FileMode.Create))
            //{
            //    using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
            //    {
            //        string text = "Hello Привет!!!";
            //        double pi = 3.141592;
            //        int num = 1000;
            //        bw.Write(text);
            //        bw.Write(pi);
            //        bw.Write(num);
            //    }
            //}


            //using (FileStream fs = new FileStream("test3.bin", FileMode.Open))
            //{
            //    using (BinaryReader br = new BinaryReader(fs, Encoding.Unicode))
            //    {
            //        string text = br.ReadString();
            //        double pi = br.ReadDouble();
            //        int num = br.ReadInt32();
            //        Console.WriteLine(text);
            //        Console.WriteLine(pi);
            //        Console.WriteLine(num);
            //    }
            //}

            DirectoryInfo dir = new DirectoryInfo(".");
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.LastWriteTime);
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.Root);
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.Attributes);

            DirectoryInfo[] dirs =  dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();

            string[] str = new string[files.Length];
            int i = 0;
            foreach (var item in dirs)
            {
                str[i++] = $"{item.Name.PadRight(25)} {"Dir".PadLeft(10)} {item.CreationTime.ToString().PadLeft(25)} {item.Attributes}";
            }
            foreach (var item in files)
            {
                str[i++] = $"{item.Name.PadRight(40)} {item.Length.ToString().PadLeft(10)} {item.CreationTime.ToString().PadLeft(25)} {item.Attributes}";
            }

            if (Directory.Exists(dir.FullName + @"\Test"))
                Directory.CreateDirectory(dir.FullName + @"\Test");


            using (StreamWriter sw = File.CreateText("text55.txt"))
            {
                sw.Write("sndnsl lkvaslslkv scs");
            }




            //string st = "afgafg rwtjhrw rtjhwwh qetqwertgq";
            //Console.WriteLine(st.DeleteSpace());
            //ExtentionString.DeleteSpace(st);

            //int[] arr = { 34, 64, 55, 67, 78, 47, 2, 7 };

            //IEnumerable<IGrouping<int, int>> res =
            //    from i
            //    in arr
            //        //where i % 2 == 0
            //        //orderby i
            //        //select i;
            //    group i by i % 10 into res1
            //    where res1.Count() > 1
            //    select res1;

            //foreach (IGrouping < int, int> item in res)
            //{
            //    Console.WriteLine($"Key {item.Key}");
            //    Console.Write("Value  ");
            //    foreach (int val in item)
            //    {
            //        Console.Write(val+ " ");
            //    }
            //    Console.WriteLine();
            //}

            //foreach (var item in res)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //arr = arr.Mult(3);
            //arr.Print();



            //MyDelegate intDelegate = null;
            //intDelegate += Sum;
            //intDelegate += Sum;
            ////Console.WriteLine(intDelegate(4,7));
            //intDelegate += delegate (int a, int b) { return a + b; };
            //intDelegate += (a, b) => { return a + b; };
            //Console.WriteLine(intDelegate(4, 7));

            //int num = 5;


            //VoidDelegate vd = null;
            //vd += delegate () { Console.WriteLine($"VD {num}"); };
            //vd();

            //(param) => { reliz metod}

            //List<GroupSt> gr = new List<GroupSt>
            //{
            //    new GroupSt {ID = 1, Name = "PV-911" },
            //    new GroupSt {ID = 2, Name = "PU-912" },
            //    new GroupSt {ID = 3, Name = "DV-913" }
            //};

            //List<Student1> students = new List<Student1>
            //    {
            //    new Student1
            //    {
            //        Name = "Tatyana",
            //        Surname = "Ivanova",
            //        BirthDay = new DateTime(1980, 12, 16),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "AA",
            //            Number = 123456
            //        },
            //        IDGroup = 1
            //    },
            //    new Student1
            //    {
            //        Name = "Ivan",
            //        Surname = "Smirnoff",
            //        BirthDay = new DateTime(1983, 3, 11),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "AB",
            //            Number = 651234
            //        },
            //         IDGroup = 2
            //    },
            //    new Student1
            //    {
            //        Name = "Olga",
            //        Surname = "Freymut",
            //        BirthDay = new DateTime(1985, 4, 20),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "AA",
            //            Number = 651234
            //        },
            //         IDGroup = 1
            //    },
            //    new Student1
            //    {
            //        Name = "Nikolay",
            //         Surname = "Drozdov",
            //        BirthDay = new DateTime(1980, 5, 25),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "CA",
            //            Number = 123456
            //        },
            //         IDGroup = 3
            //    }
            //};

            //IEnumerable<Student1> res =
            //    from g
            //    in gr
            //    join st in students on g.ID equals st.IDGroup into res1
            //    from r in res1
            //    select r;

            //foreach (var item in res)
            //{
            //    Console.WriteLine($" Group  {gr.First(g=>g.ID == item.IDGroup).Name} " + item);
            //}

            //Student1[] res =
            //    (from i
            //  in students
            //    where i.BirthDay.Year == 1980
            //    select i).ToArray();

            //for (int i = 0; i < res.Count(); i++)
            //{
            //    res[i].BirthDay = new DateTime(2020, res[i].BirthDay.Month, res[i].BirthDay.Day);
            //}

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}




            //Teacher teacher = new Teacher();
            //foreach (var item in students)
            //{
            //    teacher.examEvent += item.Exam;
            //}

            //teacher.examEvent += Teacher_examEvent;

            //teacher.examEvent -= students[3].Exam;

            //teacher.SetExam("10.10.2020");

            //StudentDelegate st = null;
            //st += students[0].Exam;
            //st += students[0].Exam;
            //st += students[0].Exam;
            //st("13.10.2020");


            //List<Student1> st80 = students.FindAll(st=>st.BirthDay.Year > 1980);

            //List<Student1> stSpring = students.FindAll(StSpring);

            //students.Sort((a, b) => DateTime.Compare(a.BirthDay, b.BirthDay));

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}

            // students.ForEach(GetFullName);
            //string[] stName = students.Select(FullName).ToArray();
            //foreach (var item in stName)
            //{
            //    Console.WriteLine(item);
            //}

            //Calc calc = new Calc();
            //string exspression = Console.ReadLine();
            //char oper = exspression[exspression.IndexOfAny("+-*/".ToCharArray())];
            //string[] numbers = exspression.Split(oper);
            //CalcDelegate calcDel = null;
            //switch (oper)
            //{
            //    case '+':
            //        calcDel = new CalcDelegate(calc.Sum);
            //        break;
            //    case '-':
            //        calcDel = calc.Sub;
            //        break;
            //    case '*':
            //        calcDel = calc.Mult;
            //        break;
            //    case '/':
            //        calcDel = calc.Div;
            //        break;
            //    default:
            //        throw new NotImplementedException();
            //}

            //Console.WriteLine(calcDel(double.Parse(numbers[0]), double.Parse(numbers[1])));


            //MyDelegate<int> intDelegate = null;
            //intDelegate += Sum;
            //Console.WriteLine(intDelegate(4, 7));
            //MyDelegate<double> dDelegate = null;
            //dDelegate += Sub;
            //Console.WriteLine(intDelegate(4, 7));
            //foreach (MyDelegate<int> item in intDelegate.GetInvocationList())
            //{
            //    Console.WriteLine(item(4, 7));
            //}

            //Console.WriteLine(MaxElemArr<int>(new int[] { 1, 5, 10, 5, 6 }));
            //Console.WriteLine(MaxElemArr<double>(new double[] { 1.2, 5.8, 10.1, 5.3, 6.1 }));
            //Console.WriteLine(SummArr<int>(new int[] { 1, 5, 10, 5, 6 }));


            //Point2D<int> p1 = new Point2D<int>(3, 5);
            //Console.WriteLine(p1);
            //Console.WriteLine(p1.GetType());

            //Point2D<double> p2 = new Point2D<double>(4.77, 6.88);
            //Console.WriteLine(p2);
            //Console.WriteLine(p2.GetType());

            //InheritClass ic = new InheritClass();
            //ic.Method2(12);

            //GenClass<int> g = new GenClass<int>();
            //g.M1(20);

            //A<int>.B a = new A<int>.B();
            //C<int>.D<string> c = new C<int>.D<string>();
            //Console.WriteLine(c.GetType());



            //Dictionary<string, int> dic = new Dictionary<string, int>()
            //{
            //    ["www"] = 555,
            //    ["ggg"] = 999
            //};
            //dic.Add("sss", 4);
            //dic.Add("sas", 14);
            //dic.Add("ssf", 24);
            //dic.Add("sbs", 34);
            //dic["aaa"] = 444;

            ////Console.WriteLine(dic["ooo"]);

            //foreach (var item in dic)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}

            //const int size = 100000000;

            //using (new OperationTimer.OperationTimer("ArraList"))
            //{
            //    ArrayList arr = new ArrayList();
            //    for (int i = 0; i < size; i++)
            //    {
            //        arr.Add(i);
            //        int x = (int)arr[i];
            //    }
            //    arr = null;
            //}

            //using (new OperationTimer.OperationTimer("List"))
            //{
            //    List<int> list = new List<int>();
            //    for (int i = 0; i < size; i++)
            //    {
            //        list.Add(i);
            //        int x = list[i];
            //    }
            //    list = null;
            //}



            //List<int> list = new List<int>();
            //list.Add(5);
            //Console.WriteLine(list[0]);



            //Hashtable group = new Hashtable();
            //group.Add(new Student1
            //{
            //    Name = "Olga",
            //    BirthDay = new DateTime(1980, 12, 16),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AA",
            //        Number = 123456
            //    }
            //}, new ArrayList { 6, 8, 10 });
            //group.Add(new Student1
            //{
            //    Name = "Ivan",
            //    BirthDay = new DateTime(1982, 12, 13),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AA",
            //        Number = 723456
            //    }
            //}, new ArrayList { 7, 9, 10 });

            //AddMark(group,"Ivan", 12);
            //AddMark(group, "Olga", 5);
            //Print(group);

            //SortedList sl = new SortedList();
            //sl.Add(new Student1
            //{
            //    Name = "Tatyana",
            //    BirthDay = new DateTime(1980, 12, 16),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AA",
            //        Number = 123456
            //    }
            //}, 55);
            //sl.Add(new Student1
            //{
            //    Name = "Olga",
            //    BirthDay = new DateTime(1980, 12, 16),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AA",
            //        Number = 123456
            //    }
            //}, 45);

            //Console.WriteLine(sl.GetByIndex(1));
            //Console.WriteLine(sl.GetKey(1));


            //foreach (var item in sl.Keys)
            //{
            //    Console.WriteLine(sl[item]);
            //}

            //Hashtable ht = new Hashtable();
            //ht.Add("one", 44);
            //ht.Add("sharp", "one");
            //ht.Add("three", "two");

            //ht.Remove("one");
            //ArrayList arr = new ArrayList(ht.Values);
            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine($"{item.GetHashCode()} - {ht[item]}");
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            //Queue q = new Queue(0, 2.5F);


            //Stack st = new Stack(5);
            //st.Push("Word");


            //ArrayList arrList1 = new ArrayList();
            //ArrayList arrList2 = new ArrayList(4);
            //ArrayList arrList3 = new ArrayList(new int[] { 3, 5, 6 });

            //Console.WriteLine(arrList1.Capacity);
            //arrList1.Add(55);
            //arrList1.Add("one");
            //arrList1.Add(new Student1
            //{
            //    Name = "Tatyana",
            //    BirthDay = new DateTime(1980, 12, 16),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AA",
            //        Number = 123456
            //    }
            //});
            //arrList1.Add(55);
            //arrList1.Add(55);
            //Console.WriteLine(arrList1.Capacity);

            //ArrayList arr5 = arrList1.GetRange(2, 2);

            //arrList1.Insert(3, 5000);

            //arrList1.AddRange(new int[] { 3, 5, 6 });

            //Console.WriteLine(arrList1.Contains(55));

            //arrList1.TrimToSize();
            //Console.WriteLine(arrList1.Capacity);

            //foreach (var item in arrList1)
            //{
            //    Console.WriteLine(item);
            //}




            //Garbage g = new Garbage();
            //try
            //{
            //    g.OpenDB();

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    g.Dispose();
            //}

            //using (Garbage g = new Garbage())
            //{
            //    g.OpenDB();
            //}

            //Console.WriteLine($"Максимальное поколение: {GC.MaxGeneration}");
            //Garbage g = new Garbage();
            //Console.WriteLine($"Поколение объекта: {GC.GetGeneration(g)}");
            //Console.WriteLine($"Занято памяти: {GC.GetTotalMemory(false)}");
            //g.CreatGarbage();
            //Console.WriteLine($"Занято памяти: {GC.GetTotalMemory(false)}");
            //GC.Collect(0);
            //Console.WriteLine($"Занято памяти: {GC.GetTotalMemory(false)}");
            //Console.WriteLine($"Поколение объекта: {GC.GetGeneration(g)}");
            //g.CreatGarbage();
            //Console.WriteLine($"Занято памяти: {GC.GetTotalMemory(false)}");
            //GC.Collect();
            //Console.WriteLine($"Занято памяти: {GC.GetTotalMemory(false)}");
            //Console.WriteLine($"Поколение объекта: {GC.GetGeneration(g)}");

            //int aslkdngfal = 5;
            //Console.WriteLine(nameof(aslkdngfal));

            //try
            //{
            //    TestNull testNull = new TestNull(null);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}



            //int a, b;
            //try
            //{
            //    a = int.Parse(Console.ReadLine());
            //    b = int.Parse(Console.ReadLine());
            //    int c = Div(a, b);
            //    Console.WriteLine(c);
            //}
            //catch(Exception e) when (e.InnerException != null)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.InnerException.Message);
            //}


            //byte a = (byte)255;
            //Console.WriteLine(a);
            //try
            //{
            //    checked
            //    {
            //        a++;
            //    }
            //}
            //catch(OverflowException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine(a);


            //int a, b;

            //try
            //{
            //    try
            //    {
            //        a = int.Parse(Console.ReadLine());
            //        b = int.Parse(Console.ReadLine());
            //        int c = a / b;
            //        throw new MyException();
            //        Console.WriteLine(c);

            //    }
            //    catch (DivideByZeroException e)
            //    {
            //        throw;
            //        //Console.WriteLine(e.DateTime_);
            //        //Console.WriteLine(e.Message);
            //        //Console.WriteLine(e.GetType().FullName);
            //        //Console.WriteLine(e.Source);
            //        //Console.WriteLine(e.StackTrace);
            //        //Console.WriteLine(e.TargetSite);
            //        //Console.WriteLine(e.HResult);
            //        //Console.WriteLine(e.HelpLink);
            //        //Console.WriteLine(e.InnerException);
            //        //Console.WriteLine(e.Data);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Что-то не так!");
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.GetType().FullName);
            //    Console.WriteLine(e.Source);
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.TargetSite);
            //}
            //finally
            //{
            //    Console.WriteLine("Выполниться всегда");
            //}


            //Student1 st1 = new Student1
            //{
            //    Name = "Tatyana",
            //    BirthDay = new DateTime(1980, 12, 16),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AA",
            //        Number = 123456
            //    }
            //};

            //Student1 st2 = (Student1)st1.Clone();

            //Console.WriteLine(st1);
            //Console.WriteLine(st2);
            //st1.Name = "Olga";
            //Console.WriteLine(st1);
            //Console.WriteLine(st2);
            //st1.StudentCard.Series = "XX";
            //Console.WriteLine(st1);
            //Console.WriteLine(st2);

            //Group group = new Group();

            //foreach (Student1 item in group)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            // group.Sort(new SurnameComparer());
            //foreach (var item in group.GetPoints())
            //{
            //    Console.WriteLine(item);
            //}




            //Director director = new Director
            //{
            //    Name = "Ivan Ivanovich",
            //    BirthDay = new DateTime(1950, 5, 15),
            //    Position = "Director",
            //    Salary = 10000
            //};

            //Console.WriteLine(director);

            //IWorker seller = new Seller
            //{
            //    Name = "Svenlana Petrovna",
            //    BirthDay = new DateTime(1970, 10, 10),
            //    Position = "Seller",
            //    Salary = 5000
            //};

            //director.ListOfWorkers = new List<IWorker>
            //{
            //    seller,
            //    new Casher
            //    {
            //        Name = "Tatyana Ivanovna",
            //        BirthDay = new DateTime(1980, 12, 16),
            //        Position = "Casher",
            //        Salary = 4000
            //    },
            //    new Cleaner
            //    {
            //        Name = "Baba Klava",
            //        BirthDay = new DateTime(1940, 1, 4),
            //        Position = "Cleaner",
            //        Salary = 2000
            //    }

            //};

            //foreach (var item in director.ListOfWorkers)
            //{
            //    Console.WriteLine(item);
            //    item.Work();
            //}





            //IndexerClass indexerClass = new IndexerClass();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(indexerClass[i]);
            //}
            //Console.WriteLine();

            //foreach (var item in Enum.GetNames(typeof(Numbers)))
            //{
            //    Console.WriteLine(indexerClass[item]);
            //}

            //IterC interC = new IterC();
            //interC.Show();

            //IA iA = new IterC();
            //iA.Show();

            //IB iB = new IterC();
            //iB.Show();





            //MultiVector mv = new MultiVector(2, 2);
            //mv[0, 0] = new Vector(3, 5);
            //mv[0, 1] = new Vector(4, 8);
            //mv[1, 0] = new Vector(1, 2);
            //mv[1, 1] = new Vector(1, 5);

            // Console.WriteLine(mv[0, 0]);

            //for (int i = 0; i < mv.Length; i++)
            //{
            //    Console.WriteLine(mv[i]);
            //}

            //for (int i = 0; i < mv.Row; i++)
            //{
            //    for (int j = 0; j < mv.Col; j++)
            //    {
            //        Console.WriteLine(mv[i, j]);
            //    }
            //}

            //mv.Print();

            //Vector a = new Vector(new Point(0, 0), new Point(1, 1));
            //Vector b = new Vector(new Point(0, 0), new Point(1, 0));
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            ////Vector c = a + b;
            //Vector c = a * 5;
            //Console.WriteLine(c);
            //// a += b;
            //Console.WriteLine(a);

            ////Employee e = new Employee("Ivan", 25, 2500);
            ////e.Print();
            //////e = -e;
            ////e++;
            ////++e;
            ////e.Print();
            ////e--;
            ////--e;
            ////e.Print();

            //if (!a)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //    Console.WriteLine("False");


            //double d = (double)a;

            //Vector s = 8;
            //Console.WriteLine(s);



            // -
            // ++
            // --

            // = . ?: is as new - не перегружаются

            //Human[] humen = new Human[] { new Employee("Ivan", 25, 2500),
            //                              new Scientist("Olga", 22, "Aspirant"),
            //                              new Student1("Serg", 25, 123456)};
            //foreach (var item in humen)
            //{
            //    item.Print();
            //    item.WhoAmI();
            //    Console.WriteLine();

            //try
            //{
            //    ((Employee)item).PrintEmployee();
            //}
            //catch
            //{
            //    Console.WriteLine("Not Employee");
            //}

            //Scientist sc = item as Scientist;
            //if (sc != null)
            //    sc.PrintScientist();
            //else
            //    Console.WriteLine("Not Scientist");


            //if (item is Student1)
            //{
            //    (item as Student1).PrintStudent1();
            //}
            //else
            //    Console.WriteLine("Not Student");

            //}

            //Employee employee = new Employee("Ivan", 25, 2500);
            //employee.Print();

            //Scientist scientist = new Scientist("Olga", 22, "Aspirant");
            //scientist.Print();

            //Student1 student = new Student1("Serg", 25, 123456);
            //student.Print();


            //MyClass m = new MyClass();
            //m.print();

            //ConsoleApplication2.MyClass mn = new ConsoleApplication2.MyClass();
            //mn.print();

            //NS::Student s = new NS::Student();



            //Student student = new Student("Ivan", 30);
            //Student student2 = new Student();
            //student2.Print();
            //student.Print();
            //student.Mark[1] = 6;

            //student.Day = 9;
            //student.Month1 = 9;
            //Console.WriteLine(student.Month1);
            //student.Print2();

            //Student student3 = new Student { Day = 20, Month1 = 5 };
            //student3.Print2();


            //int[] arr = { 1, 2, 3 };
            //int a = 5;
            //Console.WriteLine($"arr[0] = {arr[0]}, a = {a}");
            //Func1(ref arr, out a);
            //Console.WriteLine($"arr[0] = {arr[0]}, a = {a}");

            ////Console.WriteLine(Sum(new int[] { 1, 2, 3 }));
            //Console.WriteLine(Sum(3, 4, 5, 6));

            //MyStruct myStruct = new MyStruct(30, "Ivan");
            //Console.WriteLine(myStruct.Age);


            //DayOfWeek day = DayOfWeek.Monday;
            //switch (day)
            //{
            //    case DayOfWeek.Monday:
            //        break;
            //    case DayOfWeek.Tuesday:
            //        break;
            //    case DayOfWeek.Wednesday:
            //        break;
            //    case DayOfWeek.Thursday:
            //        break;
            //    case DayOfWeek.Friday:
            //        break;
            //    case DayOfWeek.Saturday:
            //        break;
            //    case DayOfWeek.Sanday:
            //        break;
            //    default:
            //        break;
            //}
            //string[] st = Enum.GetNames(typeof (DayOfWeek));
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(Enum.GetValues(typeof(DayOfWeek)).GetValue(2));
            //string s = Enum.GetName(typeof(DayOfWeek), 0);
            //Console.WriteLine(s);
            //Console.WriteLine(Enum.Format(typeof(DayOfWeek), DayOfWeek.Monday,"D"));

            //Console.WriteLine(day.GetHashCode());

            //string st1 = "1, 3, 44, 5, 66, 7, 4, 33, 22";
            //string[] st2 = st1.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //int[] arr = new int[st2.Length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(st2[i]);
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();


            //char[] st2 = { 'H', 'e', 'l', 'l', 'o' };
            //string st3 = new string(st2);
            //string st4 = new string('#', 10);
            //Console.WriteLine(st1);
            //Console.WriteLine(st2);
            //Console.WriteLine(st3);
            //Console.WriteLine(st4);

            //Console.WriteLine(st1.Contains("e"));

            //st1.CopyTo(0, st2, 2, 3);
            //Console.WriteLine(st2);
            //st1.IndexOfAny("abc".ToCharArray());
            //Console.WriteLine(st1.PadLeft(20, '#'));
            //Console.WriteLine(st1.PadRight(20, '#'));
            //string[] st7 = st1.Split(",".ToCharArray());
            //string[] st8 = st1.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in st7)
            //{
            //    Console.WriteLine(item);
            //}

            //string st9 = String.Join(", ", st7);
            //Console.WriteLine(st9);


            //int[] arr = new int[] { 10, 25, 3, 4, 5 };
            //int[] arr1 = new int[4] { 1, 2, 3, 4 };
            //int[] arr2 = new int[10];
            ////arr.CopyTo(arr2, 2);
            ////Console.WriteLine(arr.GetLength(0));
            //Console.WriteLine(arr.Rank);
            //arr.SetValue(33, 2);

            ////Array.Clear(arr, 2, 2);
            ////Array.Copy(arr, arr2, 3);
            //Console.WriteLine(Array.Find(arr, Foo));
            //int[] arr5 = Array.FindAll(arr, Foo);
            //Array.Sort(arr, 0, 3);
            //Console.WriteLine(Array.BinarySearch(arr, 25));

            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();


            //int[,] arr6 = new int[2, 3] { { 2, 4, 6 }, { 2, 4, 5 } };
            //Console.WriteLine(arr6[1, 1]);

            //int[][] arrZ = new int[3][] {new int[] {2,5,3,5},
            //               new int[] {3,4},
            //               new [] {3,3,3,4,5,6,6} };
            //Array.Sort(arrZ[0]);
            //for (int i = 0; i < arrZ.Length; i++)
            //{
            //    foreach (var item in arrZ[i])
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int? a = null;
            //Console.WriteLine(a);
            //a = a ?? 5;
            //Console.WriteLine(a);
            //string st = null;

            //int a = 5;
            //float b = 3.5F;
            ////Console.WriteLine(a);
            ////Console.WriteLine(a);
            ////Console.WriteLine(a);

            //int c = (int)(a + b);
            //Console.WriteLine(c);

            //Console.WriteLine("A={0}", a);
            //Console.WriteLine($"A={a}, C={c}");
            //Console.WriteLine(@"khdfsjhjsd sdfknhsodf");

            //int d = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(a.GetType());
            //Console.WriteLine(d);
            //int res;

            ////while( !Int32.TryParse(Console.ReadLine(), out res))
            ////                Console.WriteLine(res);
            //int f = 5;
            // switch(f)
            //{
            //    case 2:
            //        Console.WriteLine(f);
            //        break;
            //    case 4:
            //        Console.WriteLine(f);
            //        break;
            //    default:
            //        break;
            //}
            //int[] arr = new int[5];
            //Random rand = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rand.Next(20, 50);
            //}
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}



            //int @int = 8;
            //Console.WriteLine(@int);



            Console.Read();
        }

        private static void Teacher_examEvent(string st)
        {
            Console.WriteLine("Кто-то левый подписался на событие");
        }

        static int Div(int a, int b)
        {
            int c = 0;
            try
            {
                c = a / b;
            }
            catch (DivideByZeroException e)
            {
                throw new Exception("Filtr", e);
            }
            return c;
        }

        static void f1()
        {
            f2();
        }

        static void f2()
        {
            throw new Exception("XXXXXXX");
        }

        static void f()
        {
            try
            {
                f1();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        static int Sum(int b, params int[] arr)
        {
            int res = 0;
            foreach (var item in arr)
            {
                res += item;
            }
            return res;
        }


        static bool Foo(int a)
        {
            return a > 5;
        }
    }
}

namespace ConsoleApplication2
{

    class MyClass
    {
        public void print()
        {
            Console.WriteLine("ConsoleApplication2");
        }
    }
}
