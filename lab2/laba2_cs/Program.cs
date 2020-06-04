using System;
using MyLib1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            stroki str1 = new stroki("asdwasdwadsx");
            stroki str2 = new stroki("alaalasdawdawdawdsx");
            stroki str3 = new stroki("zxxadawxcvbhajerfgtrukrvkyuWkducua");

            text text1 = new text(str1);
            text1.inn(str2);
            text1.inn(str3);

            text1.output();
            Console.WriteLine();

            Console.WriteLine(text1.middle());
            Console.WriteLine();

            text1.del(3, text1.strarr);
            text1.output();
            Console.WriteLine();

            text1.delall();
            Console.WriteLine();

            text1.inn(str1);
            text1.output();
        }
    }
}
