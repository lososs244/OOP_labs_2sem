using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace laba4s
{
    class vec
    {
        private double x, y;
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public vec() { }

        public vec (double n, double m)
        {
            x = n;
            y = m;
        }
        public vec (vec v)
        {
            x = v.x;
            y = v.y;
        }

        public double length()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public static vec operator *(vec vect, double num)   //overloaded operator *
        {

            vec result = new vec();
            if (num == 0)
                throw new Exception("Increasing on 0");
            result.x = vect.x * num;
            result.y = vect.y * num;
            return result;
        }
        public static vec operator -(vec vec1, vec vec2)   //overloaded operator -
        {
            vec result = new vec();
            result.x = vec1.x - vec2.x;
            result.y = vec1.y - vec2.y;
            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minyaylov Oleh IS-92");
            double x, y;
            Console.WriteLine("Input x for V1");

            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y for V1");
            y = Convert.ToDouble(Console.ReadLine());


            vec V1 = new vec(x, y);
            vec V2 = new vec();
            vec V3 = new vec(V1);




            Console.WriteLine("Input x for V2");

            V2.X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y for V2");
            V2.Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input x for V3");
            V3.X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y for V3");
            V3.Y = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("\nVectors:\nCoords of V1 : ({0:0.0}  {1:0.0})", V1.X, V1.Y);
            Console.WriteLine("Length of V1 : {0:0.0}", V1.length());
            Console.WriteLine("Coords of V2 : ({0:0.0}  {1:0.0})", V2.X, V2.Y);
            Console.WriteLine("Length of V2 : {0:0.0}", V2.length());
            Console.WriteLine("Coords of V3 : ({0:0.0}  {1:0.0})", V3.X, V3.Y);
            Console.WriteLine("Length of V3 : {0:0.0}", V3.length());

            V1 = V3 - V2;
            Console.WriteLine("\nNew vectors :");
            Console.WriteLine("Coords of V1 : ({0:0.0}  {1:0.0})", V1.X, V1.Y);
            Console.WriteLine("Length of V1 : {0:0.0}", V1.length());
            Console.WriteLine("Coords of V2 : ({0:0.0}  {1:0.0})", V2.X, V2.Y);
            Console.WriteLine("Length of V2 : {0:0.0}", V2.length());
            Console.WriteLine("Coords of V3 : ({0:0.0}  {1:0.0})", V3.X, V3.Y);
            Console.WriteLine("Length of V3 : {0:0.0}", V3.length());
        }
    }
}
