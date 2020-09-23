using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }



    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(Point a, Point b)
        {
            X = Math.Abs(a.X - b.X);
            Y = Math.Abs(a.Y - b.Y);
        }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"Vector: X - {X}, Y - {Y}";
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }

        public static Vector operator *(Vector a, int b)
        {
            return new Vector(a.X * b, a.Y * b);
        }

        public static bool operator ==(Vector a, Vector b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Vector a, Vector b)
        {
            return a.X != b.X || a.Y != b.Y; ;
        }

        public static bool operator >(Vector a, Vector b)
        {
            return Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2)) >
                Math.Sqrt(Math.Pow(b.X, 2) + Math.Pow(b.Y, 2));
        }

        public static bool operator <(Vector a, Vector b)
        {
            return Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2)) <
                Math.Sqrt(Math.Pow(b.X, 2) + Math.Pow(b.Y, 2));
        }

        public static bool operator true(Vector a)
        {
            return a.X != 0 || a.Y != 0;
        }

        public static bool operator false(Vector a)
        {
            return a.X == 0 || a.Y == 0;
        }

        public static bool operator !(Vector a)
        {
            return a ? false : true;
        }

        //public static implicit operator double (Vector a)
        //{
        //    return Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2));
        //}

        public static explicit operator double (Vector a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y);
        }

        public static implicit operator Vector(int a)
        {
            return new Vector(a, a);
        }
    }

    class MultiVector
    {
        Vector[] vectors;

        public int Length
        {
            get { return vectors.Length; }
        }

        public MultiVector(int size)
        {
            vectors = new Vector[size];
        }

        public Vector this[int ind]
        {
            get
            {
                if (ind >= 0 && ind < vectors.Length)
                    return vectors[ind];
                throw new IndexOutOfRangeException();
            }

            set
            {
                vectors[ind] = value;
            }
        }
    }
}
