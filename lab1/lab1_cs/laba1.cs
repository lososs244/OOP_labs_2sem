using System;

namespace lab1.cs
{
    class laba1
    {
        static void Main(string[] args)
        {
            int x = 63, c = -18, v = 92;
            int x1 = 88, x2 = 88, c1 = 34, c2 = 2, v1 = 23, v2 = 52;


            Console.WriteLine(inc(x));

            Console.WriteLine(inc(c));

            Console.WriteLine(inc(v));

            Console.WriteLine(ifmore(x1, x2));

            Console.WriteLine(ifmore(c1, c2));

            Console.WriteLine(ifmore(v1, v2));

        }

        static int inc(int num)
        {
            int bit_mask = 1;
            while ((num & bit_mask) != 0)
            {
                num = Convert.ToInt32(num ^ bit_mask);
                bit_mask <<= 1;
            }
            num = Convert.ToInt32(num | bit_mask);
            return num;
        }

        static void inc_self(ref int num)
        {
            int bit_mask = 1;
            while ((num & bit_mask) != 0)
            {
                num = Convert.ToInt32(num ^ bit_mask);
                bit_mask <<= 1;
            }
            num = Convert.ToInt32(num | bit_mask);
        }

        static bool ifmore(int a, int b)
        {
            
            int f = 0, z = 1;
            while (a != 0)
            {
                if (Convert.ToBoolean(a & z) && !Convert.ToBoolean(b & z))
                {
                    f = 1;
                }
                else if (!Convert.ToBoolean(a & z) && Convert.ToBoolean(b & z))
                {
                    f = 0;
                }
                a = a >> 1;
                b = b >> 1;

            }
            if (!Convert.ToBoolean(b) && Convert.ToBoolean(f & 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void ifmore1(int a, int b)
        {
            int f = 0, z = 1;
            while (a !=0 )
            {
                if (Convert.ToBoolean(a & z) && !Convert.ToBoolean(b & z))
                {
                    f = 1;
                }
                else if (!Convert.ToBoolean(a & z) && Convert.ToBoolean(b & z))
                {
                    f = 0;
                }
                a = a >> 1;
                b = b >> 1;

            }
            if (!Convert.ToBoolean(b) && Convert.ToBoolean(f & 1))
            {
                Console.WriteLine("true\n");
            }
            else
            {
                Console.WriteLine("false\n");
            }
        }
    }
}
