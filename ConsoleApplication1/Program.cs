using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NS = NS2.NS3;
using Human1;

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

    class Program
    {
        static void Func1(ref int[] arr, out int a)
        {
            arr = new int[] { 4, 5, 6 };
            //arr[0] = 99;
            a = 88;
        }

        static void Main(string[] args)
        {
            //Console.Beep(3000, 3000);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            //Console.SetCursorPosition(10, 10);
            Console.WriteLine("Hello C#");
            Console.Title = "My C#";


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

            using (Garbage g = new Garbage())
            {
                g.OpenDB();
            }

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
                //group.Sort(new StudentCardComparer());
                //foreach (Student1 item in group)
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

        static int Div(int a, int b)
        {
            int c = 0;
            try
            {
                c = a / b;
            }
            catch(DivideByZeroException e)
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
            catch(Exception e)
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
