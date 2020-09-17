using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //enum DayOfWeek: long
    //{
    //    Monday= 10000000000, Tuesday, Wednesday, Thursday, Friday, Saturday, Sanday
    //}

    struct MyStruct
    {
        public int Age;
        public string Name;

        public MyStruct(int a, string n)
        {
            Age = a;
            Name = n;
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
            // Console.Beep(3000, 3000);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            // Console.SetCursorPosition(10, 10);
            Console.WriteLine("Hello C#");
            Console.Title = "My C#";


            Student student = new Student("Ivan", 30);
            Student student2 = new Student();
            student2.Print();
            student.Print();
            student.Mark[1] = 6;

            student.Day = 9;
            student.Month1 = 9;
            Console.WriteLine(student.Month1);
            student.Print2();

            Student student3 = new Student { Day = 20, Month1 = 5 };
            student3.Print2();


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
