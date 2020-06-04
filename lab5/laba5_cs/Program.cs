using System;

namespace laba5s
{
    class Program
    {
        class lines
        {
            private double x1, x2, y1, y2;
            public double X1
            {
                get { return x1; }
                set { x1 = value; }
            }
            public double X2
            {
                get { return x2; }
                set { x2 = value; }
            }
            public double Y1
            {
                get { return y1; }
                set { y1 = value; }
            }
            public double Y2
            {
                get { return y2; }
                set { y2 = value; }
            }
            public lines()
            {

            }
            public lines(double xf, double yf, double xs, double ys)
            {
                X1 = xf;
                X2 = xs;
                Y1 = yf;
                Y2 = ys;
            }
            public double dline()
            {
                double result;
                result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
                return result;
            }
        }
        class vidrizok : lines
        {
            private double angle;
            public double Angle
            {
                get { return angle; }
                set { angle = value; }
            }
            private double leng;
            public double Leng
            {
                get { return leng; }
                set { leng = value; }
            }
            public vidrizok(double xf, double yf, double xs, double ys) : base(xf, yf, xs, ys)
            {
                Leng = dline();
            }
            public double cosa()
            {
                Angle = Math.Acos(((X2 - X1) / Leng));
                return Angle;
            }

        }
        class stroka
        {
            private string str;
            public string Str
            {
                get
                {
                    return str;
                }
                set
                {
                    str = value;
                }
            }
            public stroka()
            {

            }
            public stroka(string a)
            {
                Str = a;
            }
            public virtual int leng()
            {
                return Str.Length;
            }
            public virtual void add(string a)
            {
                Str = Str + a;
            }

            virtual public void Lower()
            {
                
            }
            virtual public void Upper() { }

        }
        class UpCase : stroka
        {
            public UpCase (string s)
            {
                Str = Convert.ToString(s);
            }

            public override int leng()
            {
                return base.leng();
            }
            override public void Upper()
            {
                char[] temp = Str.ToCharArray();
                int counter = 0;
                for(int i= 0; i < leng(); i++)
                {
                    if(Char.IsUpper(temp[i]))
                    {
                        counter++;
                        temp[i + 1] = '/';
                    }
                }
                Str = new string(temp);
                Console.WriteLine(this.Str);
                Console.WriteLine("Number of Upper letters: {0}", counter);
            }
        }
        class LowCase : stroka
        {
            public LowCase(string s)
            {
                Str = Convert.ToString(s);
            }
            override public int leng()
            {
                return base.leng();
            }
            override public void Lower()
            {
                char[] temp = Str.ToCharArray();
                int counter = 0;
                for (int i = 0; i < leng(); i++)
                {
                    if (Char.IsLower(temp[i]))
                    {
                        counter++;
                        temp[i + 1] = (char)92;
                    }
                }
                Str = new string(temp);
                Console.WriteLine(Str);
                Console.WriteLine("Number of Lower letters: {0}",counter);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Minyaylov Oleh\nIS-92");
            lines line = new lines(3, 5, 3, 10);
            Console.WriteLine("Length of line is {0,0}", line.dline());

            vidrizok segment = new vidrizok(3, 5, 3, 10);
            Console.WriteLine("Length of segment is {0,0}", segment.Leng);
            Console.WriteLine("Angle is {0,0} rad", segment.cosa());

            stroka s = new stroka("AllMustBePRESa");
            Console.WriteLine(s.Str);
            Console.WriteLine(s.leng());
            s.add("Added");
            Console.WriteLine(s.Str);
            
            s = new LowCase(s.Str);
            Console.WriteLine(s.Str);
            Console.WriteLine(s.leng());
            s.Lower();

            s = new UpCase(s.Str);
            Console.WriteLine(s.Str);
            Console.WriteLine(s.leng());
            s.Upper();
        }
    }
}
