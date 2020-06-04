using System;

namespace MyLib1
{
    public class stroki
    {
        public string txt;
        public int len;
        public stroki(string str)
        {
            txt = str;
            len = str.Length;
        }
    }

   public class text
    {
        int count = 0;
        public string[] strarr = new string[3];


        public text(stroki str)
        {
            strarr[0] = str.txt;
            count++;
        }

        public int middle()
        {
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += strarr[i].Length;
            }
            avg = sum / 3;
            return avg;
        }

        public void output()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(strarr[i]);
            }
        }

        public void inn(stroki str)
        {
            strarr[count] = str.txt;
            count++;
        }

        public void del(int n, string[] arr)
        {
            string[] arr1 = new string[count - 1];
            for (int i = 0; i < count; i++)
            {
                if (i == (n - 1))
                {
                    if (i == (count - 1))
                    {
                        i++;
                    }
                    else
                    {
                        arr1[i] = arr[i + 1];
                        i++;
                    }
                }
                else
                {
                    arr1[i] = arr[i];
                }
            }
            count--;
            strarr = arr1;
        }

        public void delall()
        {
            Array.Clear(strarr, 0, count);
            count = 0;
            Console.WriteLine("text was deleted!");
        }

    }
}
