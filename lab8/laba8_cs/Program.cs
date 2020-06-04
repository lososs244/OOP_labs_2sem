using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Specialized;
using System.Net.Http;

namespace laba8s
{
    

    class Queue
    {
        public delegate void MyDelegate(string mes);
        public event MyDelegate Notify;
        
        private int[] arr = new int[6];
        public int[] Arr
        {
            get
            {
                return arr;
            }
            set
            {
                arr = value;
            }
        }
        public int Size { get; set; }

        public Queue()
        {
            Size = 0;
            this.Notify += Message;

        }
        
        
        public void Add(int num)
        {
            if(Size < 6)
            {
                Arr[Size] = num;
                Size++;
            }
            else
            {
                Notify?.Invoke("The queue is full !!!");
            }
        }
        public void Del()
        {
            if(Size == 0)
            {
                Notify?.Invoke("There is nothing to delete !!!");
            }
            else
            {
                Size--;
            }
        }

        public void Output()
        {
            for(int i = 0; i<Size; i++)
            {
                Console.WriteLine($"{Arr[i]}");
            }
        }
        public void Message(string mes)
        {
            Console.WriteLine(mes);
        }
        public void Sort()
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Notify?.Invoke("The queue was sorted !!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Add(1);
            queue.Add(3);
            queue.Add(2);
            queue.Add(5);
            queue.Add(7);
            queue.Add(4);
            queue.Output();
            queue.Add(6);

            queue.Sort();
            Console.WriteLine("");
            queue.Output();

            queue.Del();
            queue.Del();
            queue.Del();
            queue.Del();
            queue.Del();
            queue.Del();
            queue.Del();
        }
    }
}
