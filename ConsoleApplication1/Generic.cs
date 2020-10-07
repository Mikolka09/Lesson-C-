using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point2D<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }

        public Point2D()
        {
            X = default(T);
            Y = default(T);
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }


    }

    class Point3D : Point2D<int>
    {
        public int Z { get; set; }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return base.ToString() + $", Z = {Z}";
        }
    }

    class GenericClass<T>
    {
        public void Method1(T obj)
        {
            Console.WriteLine($"M1 = {obj}");
        }

        public virtual void Method2(T data)
        {
            Console.WriteLine($"M2 - {data}");
        }
    }

    class InheritClass : GenericClass<int>
    {
        public override void Method2(int data)
        {
            Console.WriteLine($"M2 Inherit - {data}");
        }
    }

    class BaseClass
    {
        protected int a = 9;
    }

    class GenClass<T> : BaseClass
    {
        public void M1(T obj)
        {
            Console.WriteLine($"Base - {a}");
            Console.WriteLine($"Generic - {obj}");
        }
    }

    class A<T>
    {
        public class B
        {

        }
    }

    class C<T>
    {
        public class D<U>
        {

        }
    }
}
