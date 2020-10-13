using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate double CalcDelegate(double a, double b);

    class Calc
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Mult(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            if(b!= 0)
            return a / b;
            throw new DivideByZeroException();
        }
    }

    static class Extention
    {
        public static string DeleteSpace(this string st)
        {
            return st.Replace(" ", "");
        }

        public static int[] Mult(this int[]arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= n;
            }
            return arr;
        }

        public static void Print(this int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

   


}
