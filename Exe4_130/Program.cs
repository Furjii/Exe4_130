using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_130
{
    class Stacks
    {
        private string[] furji;
        private int top;
        private int max;

        public Stacks()
        {
            furji = new string[49];
            top = -1;
            max = 49;
        }

        public void push()
        {
            string item;
            if (top == max - 1)
            {
                Console.WriteLine("\nMaksimal Data");
            }
            else
            {
                Console.WriteLine("Masukkan Data");
                item = Console.ReadLine();
                top = top + 1;
                furji[top] = item;
                Console.WriteLine("Data telah di Push");
            }
        }

        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Tidak ada data yang bisa di Pop/hapus");
            }

            else
            {
                top = top - 1;
                Console.WriteLine("Data Telah di Pop/hapus");
            }
        }

        void Display()
        {
            for (int i = top; i >= 0; i++)
            {
                Console.WriteLine(furji[i]);
            }
            if (top == -1)
            {
                Console.WriteLine("Stack Tidak Ada");
            }
        }
        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {

            }
        }
    }
}
