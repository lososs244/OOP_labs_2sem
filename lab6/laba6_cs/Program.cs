using System;

namespace laba6s
{
    class Program
    {
        class variable
        {
            private double a, c, d, result;
            public double A
            {
                get { return a; }
                set { a = value; }
            }
            public double C
            {
                get { return c; }
                set { c = value; }
            }
            public double D
            {
                get { return d; }
                set { d = value; }
            }
            public double Res
            {
                get
                {
                    return result;
                }
                set
                {
                    result = value;
                }
            }
            public variable(double a, double c, double d)
            {
                A = a;
                C = c;
                D = d;
            }
            public void calculate()
            {
                try
                {
                    if (1 - (a / 4) <= 0)
                    {
                        throw new Exception("Неправильное подлогарифмическое выражение");
                    }
                    else if(Math.Log(1 - (a / 4)) == 0)
                    {
                        throw new DivideByZeroException("Деление на ноль невозможно");
                    }
                    Res = ((2 * c) - d / 23) / Math.Log(1 - (a / 4));
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"Exeption: {e.Message}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Exeption: {ex.Message}");
                }
                
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Minyailov Oleh\nIS-92");

            double[] arr = new double[5];

            variable v1 = new variable(0, 2, 1);
            variable v2 = new variable(1, 1, 0);
            variable v3 = new variable(3, 23, 22);
            variable v4 = new variable(2, 8, 12);
            variable v5 = new variable(5, 6, 1);

            v1.calculate();
            v2.calculate();
            v3.calculate();
            v4.calculate();
            v5.calculate();

            arr[0] = v1.Res;
            arr[1] = v2.Res;
            arr[2] = v3.Res;
            arr[3] = v4.Res;
            arr[4] = v5.Res;

            for(int i=0; i<5; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //((2 * c) - d / 23) / (Math.Log(1 - (a / 4)));
        }
    }
}
