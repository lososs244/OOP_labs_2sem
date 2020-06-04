using System;

namespace laba7s
{
    class Program
    {
        class Node
        {
            public int Data { get; set; }       //значення вузла
            public Node Next { get; set; }      //ссилка на наступний вузол
            public Node(int a)                  //конструктор з параметрами 
            {       
                Data = a;          
            }
        }
        class list
        {
            public Node head = null;
            public int Size { get; set; }  //розмір ланцюга 
            public void Push(int item)  //додавання вузлів після першого елемента
            {
                Node node = new Node(item);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    node.Next = head.Next;
                    head.Next = node;
                    
                }
                Size++;
            }

            public int count()          //рахування кількості вузлів, значення яких кратне 5
            {
                int counter = 0;

                Node p = head;

                while (p != null && p.Next != null)             //цикл пошуку потрібних вузлів, лічильник їх кількості
                {
                    if(p.Data % 5 == 0)
                    {
                        counter++;
                    }
                    p = p.Next;
                }
                Console.WriteLine($"Количество чисел, кратных 5:  {counter}");
                return counter;
            }
            
            public void Del()           //відалення вузла з ланцюга
            {
                
                Node p = head;          
                Node max = head;

                while (p != null && p.Next != null)
                {
                    if(p.Data > max.Data)
                    {
                        max = p;
                    }
                    p = p.Next;
                }

                while (max.Next != null)
                {
                    p = max.Next;
                    max.Next = p.Next;
                    Size--;
                }
            }
            public void Output()                //вивід на консоль вузлів та їх значень
            {
                Node p = head;
                int z = 0;
                while (p != null)
                {
                    z++;
                    Console.WriteLine($"Node {z}:   {p.Data}");
                    p = p.Next;
                }
            }
        }
        
        static void Main(string[] args)
        {
            list l = new list();
            l.Push(5);
            l.Push(0);
            l.Push(6);
            l.Push(2);
            l.Push(11);
            l.Push(2);
            l.Push(13);
            l.Push(5);

            Console.WriteLine();
            l.Output();
            l.count();
            Console.WriteLine("\n");

            l.Del();
            l.Output();
        }
    }
}
