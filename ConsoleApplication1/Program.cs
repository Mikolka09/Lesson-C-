using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(3000, 3000);
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
           // Console.SetCursorPosition(10, 10);
            Console.WriteLine("Hello C#");
            Console.Title = "My C#";

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
            int[] arr = new int[5];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(20, 50);
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            
            

            //int @int = 8;
            //Console.WriteLine(@int);



            Console.Read();
        }
    }
}
