using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3S
{
    class incap
    {
        Random rnd = new Random();
        private int[,] arr = new int[5, 5];
        public int[,] Arr { get => arr; set => arr = value; }
        public incap()
        {
            input();
        }

        public int this[int i, int j]
        {
            get
            {
                if (i >= 0 && i < 5 && j >= 0 && j < 5) 
                {
                    return Arr[i, j]; 
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (i >= 0 && i < 5 && j >= 0 && j < 5)
                {
                    Arr[i, j] = value;
                }
                
            }
        }
        public void input() 
        {
            for(int i =0; i<5; i++)
            {
                for (int j =0; j<5; j++)
                {
                    this[i, j] = rnd.Next(9);
                }
            }
            
        }  
    }
    class Program
    {
        static void Main(string[] args)
        {
            incap matrix = new incap();

            Console.WriteLine(matrix[3, 4]);
            Console.WriteLine(matrix[6, 6]);
        }
    }
}
